using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Aop.Api.Example
{
    public class BizLicXjjH5
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        

        // 预启动
        public static void H5GetStartUrl_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5GetStartUrlRequest request = new H5GetStartUrlRequest();
            // 加载接口参数
            H5GetStartUrlRequestModel model = new H5GetStartUrlRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                ClientType = 1,
                NotifyURL = "http://www.abcdef.com/api/notify",
                Color = "#007AFF",
                ReturnURL = "",
                CustomerTitle = 1
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5GetStartUrlResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询个体工商户状态
        public static void H5EcoCityAicStatus_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5EcoCityAicStatusRequest request = new H5EcoCityAicStatusRequest();
            // 加载接口参数
            H5EcoCityAicStatusRequestModel model = new H5EcoCityAicStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                RealName = "张三",
                IDCard = "110101198010211242",
                OpenID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5EcoCityAicStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 获取基础配置信息
        public static YzhConfig GetConfig()
        {
            YzhConfig config = new YzhConfig();
            // 设置接口基础地址
            config.ServerUrl = "";
            // 设置平台企业 ID
            config.DealerID = "";
            // 设置综合服务主体 ID
            config.BrokerID = "";
            // 设置 App Key
            config.AppKey = "";
            // 设置平台企业私钥
            config.PrivateKey = "";
            // 设置云账户公钥
            config.YzhPublicKey = "";
            // 设置 3DES Key
            config.Des3Key = "";
            // 设置签名方式，rsa 或 sha256
            config.SignType = "";

            return config;
        }
    }
}
