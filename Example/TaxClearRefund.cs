using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 连续劳务税费退补
    /// </summary>
    public class TaxClearRefund
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
        /// 查询税费清缴完成结果
        /// </summary>
        public static void GetClearTaxInfo()
        {
            // 实例化具体 API 对应的 request 类
            GetClearTaxInfoRequest request = new GetClearTaxInfoRequest();

            // 配置请求参数
            GetClearTaxInfoRequestModel model = new GetClearTaxInfoRequestModel
            {
                BrokerID = Config.BrokerID,
                DealerID = Config.DealerID,
                TaxMonth = "2025-10",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetClearTaxInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetClearTaxInfoResponseModel data = res.Data;
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
        /// 查询税费清缴明细文件
        /// </summary>
        public static void GetClearTaxFile()
        {
            // 实例化具体 API 对应的 request 类
            GetClearTaxFileRequest request = new GetClearTaxFileRequest();

            // 配置请求参数
            GetClearTaxFileRequestModel model = new GetClearTaxFileRequestModel
            {
                BrokerID = Config.BrokerID,
                DealerID = Config.DealerID,
                TaxMonth = "2025-10",
                BatchID = "10313232135454132",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetClearTaxFileResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetClearTaxFileResponseModel data = res.Data;
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
        /// 查询税费退补完成结果
        /// </summary>
        public static void GetRefundTaxInfo()
        {
            // 实例化具体 API 对应的 request 类
            GetRefundTaxInfoRequest request = new GetRefundTaxInfoRequest();

            // 配置请求参数
            GetRefundTaxInfoRequestModel model = new GetRefundTaxInfoRequestModel
            {
                BrokerID = Config.BrokerID,
                DealerID = Config.DealerID,
                TaxMonth = "2025-10",
                BatchID = "10313232135454132",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetRefundTaxInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    RefundTaxData data = res.Data;
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
