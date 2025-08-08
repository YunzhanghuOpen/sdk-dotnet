using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 用户信息收集
    /// </summary>
    public class UserCollect
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
        /// 查询手机号码绑定状态
        /// </summary>
        public static void GetUserCollectPhoneStatus()
        {
            // 实例化具体 API 对应的 request 类
            GetUserCollectPhoneStatusRequest request = new GetUserCollectPhoneStatusRequest();

            // 配置请求参数
            GetUserCollectPhoneStatusRequestModel model = new GetUserCollectPhoneStatusRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "userId1234567890",
                RealName = "张三",
                IDCard = "11010519491231002X",
                CertificateType = 0
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetUserCollectPhoneStatusResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetUserCollectPhoneStatusResponseModel data = res.Data;
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
        /// 获取收集手机号码页面

        /// </summary>
        public static void GetUserCollectPhoneUrl()
        {
            // 实例化具体 API 对应的 request 类
            GetUserCollectPhoneUrlRequest request = new GetUserCollectPhoneUrlRequest();

            // 配置请求参数
            GetUserCollectPhoneUrlRequestModel model = new GetUserCollectPhoneUrlRequestModel
            {
                Token = "testToken",
                Color = "",
                URL = "https://www.example.com",
                RedirectURL = "",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetUserCollectPhoneUrlResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetUserCollectPhoneUrlResponseModel data = res.Data;
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

