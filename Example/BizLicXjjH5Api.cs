using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 个体工商户注册（云账户新经济 H5+API）
    /// </summary>
    public class BizLicXjjH5Api
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
        /// 工商实名信息录入
        /// </summary>
        public static void H5PreCollectBizlicMsg()
        {
            // 实例化具体 API 对应的 request 类
            H5PreCollectBizlicMsgRequest request = new H5PreCollectBizlicMsgRequest();

            // 配置请求参数
            H5PreCollectBizlicMsgRequestModel model = new H5PreCollectBizlicMsgRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                PhoneNo = "188****8888",
                IDCard = "11010519491231002X",
                RealName = "张三",
                IDCardAddress = "北京市朝阳区",
                IDCardAgency = "北京市朝阳区派出所",
                IDCardNation = "20",
                IDCardValidityStart = "2020-10-01",
                IDCardValidityEnd = "2040-10-01",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5PreCollectBizlicMsgResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    H5PreCollectBizlicMsgResponseModel data = res.Data;
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
        /// 预启动
        /// </summary>
        public static void H5APIGetStartUrl()
        {
            // 实例化具体 API 对应的 request 类
            H5APIGetStartUrlRequest request = new H5APIGetStartUrlRequest();

            // 配置请求参数
            H5APIGetStartUrlRequestModel model = new H5APIGetStartUrlRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                ClientType = 2,
                NotifyURL = "https://www.example.com",
                Color = "#007AFF",
                ReturnURL = "https://www.example.com",
                CustomerTitle = 1,
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5APIGetStartUrlResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    H5APIGetStartUrlResponseModel data = res.Data;
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
        /// 查询个体工商户状态
        /// </summary>
        public static void H5APIEcoCityAicStatus()
        {
            // 实例化具体 API 对应的 request 类
            H5APIEcoCityAicStatusRequest request = new H5APIEcoCityAicStatusRequest();

            // 配置请求参数
            H5APIEcoCityAicStatusRequestModel model = new H5APIEcoCityAicStatusRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                RealName = "张三",
                IDCard = "11010519491231002X",
                OpenID = "AIjdiahekrSDHOjkdi",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5APIEcoCityAicStatusResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    H5APIEcoCityAicStatusResponseModel data = res.Data;
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
