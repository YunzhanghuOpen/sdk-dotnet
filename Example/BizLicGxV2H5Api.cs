using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 个体工商户注册（云账户共享大额 H5+API）
    /// </summary>
    public class BizLicGxV2H5Api
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
        public static void GxV2H5APIPreCollectBizlicMsg()
        {
            // 实例化具体 API 对应的 request 类
            GxV2H5APIPreCollectBizlicMsgRequest request = new GxV2H5APIPreCollectBizlicMsgRequest();

            // 配置请求参数
            GxV2H5APIPreCollectBizlicMsgRequestModel model = new GxV2H5APIPreCollectBizlicMsgRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "userId1234567890",
                PhoneNo = "+86-188****8888",
                IDCard = "11010519491231002X",
                RealName = "张三",
                IDCardAddress = "省级行政区名称区县级行政区名称具体住宿地址",
                IDCardAgency = "区县公安局名称",
                IDCardNation = "20",
                IDCardValidityStart = "2022-02-22",
                IDCardValidityEnd = "2042-02-22",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GxV2H5APIPreCollectBizlicMsgResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GxV2H5APIPreCollectBizlicMsgResponseModel data = res.Data;
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
        public static void GxV2H5APIGetStartUrl()
        {
            // 实例化具体 API 对应的 request 类
            GxV2H5APIGetStartUrlRequest request = new GxV2H5APIGetStartUrlRequest();

            // 配置请求参数
            GxV2H5APIGetStartUrlRequestModel model = new GxV2H5APIGetStartUrlRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "userId1234567890",
                ClientType = 2,
                NotifyURL = "https://www.example.com",
                Color = "#007AFF",
                ReturnURL = "https://www.example.com",
                CustomerTitle = 1,
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GxV2H5APIGetStartUrlResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GxV2H5APIGetStartUrlResponseModel data = res.Data;
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
        public static void GxV2H5APIGetAicStatus()
        {
            // 实例化具体 API 对应的 request 类
            GxV2H5APIGetAicStatusRequest request = new GxV2H5APIGetAicStatusRequest();

            // 配置请求参数
            GxV2H5APIGetAicStatusRequestModel model = new GxV2H5APIGetAicStatusRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OpenID = "openId1234567890",
                RealName = "张三",
                IDCard = "11010519491231002X",
                DealerUserID = "userId1234567890",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GxV2H5APIGetAicStatusResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GxV2H5APIGetAicStatusResponseModel data = res.Data;
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
