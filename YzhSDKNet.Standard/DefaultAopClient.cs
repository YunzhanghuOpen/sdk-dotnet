using Aop.Api.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

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
        /// 执行请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public T Execute<T>(IAopRequest<T> request) where T : AopResponse
        {
            // 检查配置是否为空
            if (this.config == null)
            {
                throw new AopException("config is null");
            }

            // 检查 dealer_id 是否为空
            if (string.IsNullOrEmpty(this.config.DealerID))
            {
                throw new AopException("dealer_id is null or empty");
            }

            // 检查 app_key 是否为空
            if (string.IsNullOrEmpty(this.config.AppKey))
            {
                throw new AopException("app_key is null or empty");
            }

            // 检查 des3_key 是否为空
            if (string.IsNullOrEmpty(this.config.Des3Key))
            {
                throw new AopException("des3_key is null or empty");
            }

            // 检查 sign_type 是否为空
            if (string.IsNullOrEmpty(this.config.SignType))
            {
                throw new AopException("sign_type is null or empty");
            }

            // 检查 sign_type 是否符合要求
            if (!this.config.SignType.ToLower().Equals("sha256") && !this.config.SignType.Equals("rsa"))
            {
                throw new AopException("sign_type only support sha256 or rsa");
            }

            // 检查 rsa 签名类型下 private_key 是否为空
            if (this.config.SignType.ToLower().Equals("rsa") && string.IsNullOrEmpty(this.config.PrivateKey))
            {
                throw new AopException("private_key is null or empty");
            }

            // 获取业务参数
            var bizModel = request.GetBizModel();
            // 验证业务参数是否为空
            if (bizModel == null)
            {
                throw new AopException("biz_model is null");
            }
            string plaintext = JsonConvert.SerializeObject(bizModel);
            // 对业务明文信息进行加密，生成密文数据
            string data = DESEncrypt.Encrypt(plaintext, this.config.Des3Key);
            // 获取随机数字段
            string mess = request.GetMess();
            // 获取当前时间戳
            string timestamp = request.GetTimestamp();
            // 封装待签名字符串
            string message = $"data={data}&mess={mess}&timestamp={timestamp}&key={this.config.AppKey}";
            string sign = Signature.Sign(message, this.config.SignType, this.config.AppKey, this.config.PrivateKey);

            // 封装相关请求参数
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

            string body;
            if (method == HttpMethod.Post.Method)
            {
                body = webUtils.DoPost(url, parameters);
            }
            else
            {
                body = webUtils.DoGet(url, parameters);
            }

            string srcBody = body;

            // 如果数据是加密返回，只有返回的 data 字段是加密的，对 data 字段进行解密
            if (bizModel.GetNeedEncrypt())
            {
                srcBody = Parese(body, this.config.Des3Key);
            }

            T response = JsonConvert.DeserializeObject<T>(srcBody);
            response.Body = body;
            return response;
        }

        /// <summary>
        /// 对密文数据进行解密
        /// </summary>
        /// <param name="body">原始响应数据</param>
        /// <param name="des3Key">3DES Key</param>
        /// <returns></returns>
        private string Parese(string body, string des3Key)
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
                        value = DESEncrypt.Decrypt(value, des3Key);
                        data.Add(key, JsonConvert.DeserializeObject<JObject>(value));
                        continue;
                    }
                    data.Add(key, value);
                }
                body = JsonConvert.SerializeObject(data);
            }
            return body;
        }
    }
}
