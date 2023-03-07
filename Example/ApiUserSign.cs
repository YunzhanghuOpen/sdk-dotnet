using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Aop.Api.Example
{
    public class ApiUserSign
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        
        

        // 获取协议预览 URL
        public static void ApiUseSignContract_Example()
        {
            // 实例化具体 API 对应的 request 类
            ApiUseSignContractRequest request = new ApiUseSignContractRequest();
            // 加载接口参数
            ApiUseSignContractRequestModel model = new ApiUseSignContractRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUseSignContractResponse res = client.Execute(request);

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

        // 用户签约
        public static void ApiUserSign_Example()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignRequest request = new ApiUserSignRequest();
            // 加载接口参数
            ApiUserSignRequestModel model = new ApiUserSignRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
                CardType = "idcard"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUserSignResponse res = client.Execute(request);

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

        // 获取用户签约状态
        public static void GetApiUserSignStatus_Example()
        {
            // 实例化具体 API 对应的 request 类
            GetApiUserSignStatusRequest request = new GetApiUserSignStatusRequest();
            // 加载接口参数
            GetApiUserSignStatusRequestModel model = new GetApiUserSignStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetApiUserSignStatusResponse res = client.Execute(request);

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

        // 用户解约（测试账号专用）
        public static void ApiUserSignRelease_Example()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignReleaseRequest request = new ApiUserSignReleaseRequest();
            // 加载接口参数
            ApiUserSignReleaseRequestModel model = new ApiUserSignReleaseRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
                CardType = "idcard"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUserSignReleaseResponse res = client.Execute(request);

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

