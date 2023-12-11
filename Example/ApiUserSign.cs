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
        /// <summary>
        /// 获取基础配置信息
        /// </summary>
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        /// <summary>
        /// 客户端实现
        /// </summary>
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        /// <summary>
        /// 获取协议预览 URL
        /// </summary>
        public static void ApiUseSignContract()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignContractRequest request = new ApiUserSignContractRequest();

            // 配置请求参数
            ApiUserSignContractRequestModel model = new ApiUserSignContractRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ApiUserSignContractResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ApiUserSignContractResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 用户签约
        /// </summary>
        public static void UserSign()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignRequest request = new ApiUserSignRequest();

            // 配置请求参数
            ApiUserSignRequestModel model = new ApiUserSignRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
                CardType = "idcard",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ApiUserSignResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ApiUserSignResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 获取用户签约状态
        /// </summary>
        public static void GetApiUserSignStatus()
        {
            // 实例化具体 API 对应的 request 类
            GetApiUserSignStatusRequest request = new GetApiUserSignStatusRequest();

            // 配置请求参数
            GetApiUserSignStatusRequestModel model = new GetApiUserSignStatusRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetApiUserSignStatusResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetApiUserSignStatusResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 用户解约（测试账号专用）
        /// </summary>
        public static void ApiUserSignRelease()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignReleaseRequest request = new ApiUserSignReleaseRequest();

            // 配置请求参数
            ApiUserSignReleaseRequestModel model = new ApiUserSignReleaseRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
                CardType = "idcard",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ApiUserSignReleaseResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ApiUserSignReleaseResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }
    }
}