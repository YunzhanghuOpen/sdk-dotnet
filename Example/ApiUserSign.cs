using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 用户签约（API 签约）
    /// </summary>
    public class ApiUserSign
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 获取协议预览 URL
        public static void ApiUseSignContract()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignContractRequest request = new ApiUserSignContractRequest();
            
            // 加载接口参数
            ApiUserSignContractRequestModel model = new ApiUserSignContractRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            ApiUserSignContractResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApiUserSignContractResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 用户签约
        public static void ApiUserSign()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignRequest request = new ApiUserSignRequest();

            // 加载接口参数
            ApiUserSignRequestModel model = new ApiUserSignRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
                CardType = "idcard",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            ApiUserSignResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApiUserSignResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 获取用户签约状态
        public static void GetApiUserSignStatus()
        {
            // 实例化具体 API 对应的 request 类
            GetApiUserSignStatusRequest request = new GetApiUserSignStatusRequest();

            // 加载接口参数
            GetApiUserSignStatusRequestModel model = new GetApiUserSignStatusRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetApiUserSignStatusResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetApiUserSignStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 用户解约（测试账号专用）
        public static void ApiUserSignRelease()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignReleaseRequest request = new ApiUserSignReleaseRequest();

            // 加载接口参数
            ApiUserSignReleaseRequestModel model = new ApiUserSignReleaseRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
                CardType = "idcard",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            ApiUserSignReleaseResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApiUserSignReleaseResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}