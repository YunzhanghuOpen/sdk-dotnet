using Aop.Api.Request;
using Aop.Api.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Aop.Api
{
    /// <summary>
    /// AOP 客户端
    /// </summary>
    public class DefaultAopClient : IAopClient
    {
        /// <summary>
        /// 请求相关配置
        /// </summary>
        private YzhConfig config;

        /// <summary>
        /// 网络
        /// </summary>
        private WebUtils webUtils;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAopClient"/> class.
        /// 客户端实现
        /// </summary>
        /// <param name="config">相关配置</param>
        public DefaultAopClient(YzhConfig config)
        {
            this.config = config;
            this.webUtils = new WebUtils();
        }

        /// <summary>
        /// 设置请求超时时间
        /// </summary>
        /// <param name="timeout">超时时间，单位：毫秒</param>
        public void SetTimeout(int timeout)
        {
            this.webUtils.Timeout = timeout;
        }

        /// <summary>
        /// 发送请求
        /// </summary>
        /// <typeparam name="T">响应实体</typeparam>
        /// <param name="request">请求实体</param>
        /// <returns>响应实体</returns>
        public T Execute<T>(IAopRequest<T> request)
            where T : AopResponse
        {
            // 校验基础参数是否为空
            this.VerifyConfigIsEmpty();

            // 获取业务参数
            AopObject bizModel = request.GetBizModel();

            // 验证业务参数是否为空
            if (bizModel == null)
            {
                throw new AopException("biz_model can't be null");
            }

            string plaintext = JsonConvert.SerializeObject(bizModel);

            // 对明文信息进行加密
            string data = DESEncrypt.Encrypt(plaintext, this.config.TripleDesKey);

            // 获取随机字符串
            string mess = request.GetMess();

            // 获取当前时间戳
            string timestamp = request.GetTimestamp();

            // 封装待签名字符串
            string message = $"data={data}&mess={mess}&timestamp={timestamp}&key={this.config.AppKey}";

            // 获取签名
            string sign = Signature.Sign(message, this.config.SignType, this.config.AppKey, this.config.PrivateKey);

            // 封装请求体
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { YzhConstants.Data,data},
                { YzhConstants.Mess,mess},
                { YzhConstants.Timestamp,timestamp},
                { YzhConstants.Sign,sign},
                { YzhConstants.SignType,this.config.SignType},
            };

            // 封装请求头
            this.webUtils.CustomHeaders = new Dictionary<string, string>
            {
                { YzhConstants.DealerID,this.config.DealerID},
                { YzhConstants.RequestID,request.GetRequestID()},
            };

            string url = this.config.ServerUrl + request.GetApiPath();
            string method = request.GetMethod();

            string body = this.webUtils.DoHttpClient(method, url, parameters);

            string srcBody = body;

            // 如果数据是加密返回，对 data 字段进行解密
            if (bizModel.GetNeedEncrypt())
            {
                srcBody = this.Parese(body, this.config.TripleDesKey);
            }

            T response = JsonConvert.DeserializeObject<T>(srcBody);
            response.Body = body;
            return response;
        }

        /// <summary>
        /// 处理云账户回调请求
        /// </summary>
        /// <typeparam name="T">回调明文实体</typeparam>
        /// <param name="request">回调输入内容</param>
        /// <returns>回调明文实体</returns>
        /// <exception cref="AopException">错误信息</exception>
        public T CallBackExecute<T>(YzhCallbackRequest<T> request)
            where T : AopObject
        {
            // 校验基础参数是否为空
            this.VerifyConfigIsEmpty();

            // 校验回调参数是否为空
            this.VerifyNotifyIsEmpty(request);

            // 封装待签名字符串
            string message = $"data={request.Data}&mess={request.Mess}&timestamp={request.Timestamp}&key={this.config.AppKey}";

            // 验证回调请求签名是否正确
            if (!Signature.Verify(message, request.Sign, request.SignType, this.config.AppKey, this.config.YzhPublicKey))
            {
                throw new AopException("sign verify failed");
            }

            // 解密数据
            string data = DESEncrypt.Decrypt(request.Data, this.config.TripleDesKey);

            T response = JsonConvert.DeserializeObject<T>(data);

            return response;
        }

        /// <summary>
        /// 对密文数据进行解密
        /// </summary>
        /// <param name="body">原始响应数据</param>
        /// <param name="tripleDesKey">3DES KEY</param>
        /// <returns>响应数据解密结果</returns>
        private string Parese(string body, string tripleDesKey)
        {
            IDictionary<string, string> json;
            try
            {
                json = JsonConvert.DeserializeObject<IDictionary<string, string>>(body);
            }
            catch
            {
                json = null;
            }

            if (json != null)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                foreach (string key in json.Keys)
                {
                    string value = json[key];

                    // 对 data 字段进行解密
                    if (key.Equals(YzhConstants.Data) && !string.IsNullOrEmpty(value))
                    {
                        value = DESEncrypt.Decrypt(value, tripleDesKey);
                        data.Add(key, JsonConvert.DeserializeObject<JObject>(value));
                        continue;
                    }

                    data.Add(key, value);
                }

                body = JsonConvert.SerializeObject(data);
            }

            return body;
        }

        /// <summary>
        /// 校验基础参数是否为空
        /// </summary>
        private void VerifyConfigIsEmpty()
        {
            // 检查配置是否为空
            if (this.config == null)
            {
                throw new AopException("Config can't be null");
            }

            // 检查 DealerID 是否为空
            if (string.IsNullOrEmpty(this.config.DealerID))
            {
                throw new AopException("DealerID can't be null or empty");
            }

            // 检查 AppKey 是否为空
            if (string.IsNullOrEmpty(this.config.AppKey))
            {
                throw new AopException("AppKey can't be null or empty");
            }

            // 检查 TripleDesKey 是否为空
            if (string.IsNullOrEmpty(this.config.TripleDesKey))
            {
                throw new AopException("TripleDesKey can't be null or empty");
            }

            // 检查 SignType 是否为空
            if (string.IsNullOrEmpty(this.config.SignType))
            {
                throw new AopException("SignType can't be null or empty");
            }

            // 检查 SignType 是否符合要求
            if (!this.config.SignType.ToLower().Equals("sha256") && !this.config.SignType.Equals("rsa"))
            {
                throw new AopException("SignType only support sha256 or rsa");
            }

            // 检查 RSA 签名类型下 PrivateKey 是否为空
            if (this.config.SignType.ToLower().Equals("rsa") && string.IsNullOrEmpty(this.config.PrivateKey))
            {
                throw new AopException("PrivateKey can't be null or empty");
            }
        }

        /// <summary>
        /// 校验回调参数是否为空
        /// </summary>
        /// <typeparam name="T">回调明文实体</typeparam>
        /// <param name="request">回调输入内容</param>
        private void VerifyNotifyIsEmpty<T>(YzhCallbackRequest<T> request)
            where T : AopObject
        {
            // 检查 RSA 签名类型下云账户公钥是否为空
            if (this.config.SignType.Equals("rsa") && string.IsNullOrEmpty(this.config.YzhPublicKey))
            {
                throw new AopException("YzhPublicKey can't be null or empty");
            }

            // 检查回调内容是否为 null
            if (request == null)
            {
                throw new AopException("request can't be null");
            }

            // 检查 data 是否为空
            if (string.IsNullOrEmpty(request.Data))
            {
                throw new AopException("data can't be empty");
            }

            // 检查 mess 是否为空
            if (string.IsNullOrEmpty(request.Mess))
            {
                throw new AopException("mess can't be empty");
            }

            // 检查 timestamp 是否为空
            if (string.IsNullOrEmpty(request.Timestamp))
            {
                throw new AopException("timestamp can't be empty");
            }

            // 检查 sign 是否为空
            if (string.IsNullOrEmpty(request.Sign))
            {
                throw new AopException("sign can't be empty");
            }

            // 检查 sign_type 是否为空
            if (string.IsNullOrEmpty(request.SignType))
            {
                throw new AopException("sign_type can't be empty");
            }

            // 检查 sign_type 是否一致
            if (!this.config.SignType.Equals(request.SignType))
            {
                throw new AopException("sign_type not equal");
            }
        }
    }
}
