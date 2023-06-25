using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;
using System.Collections.Generic;

namespace Aop.Api.Example
{
    /// <summary>
    /// 对账文件获取
    /// </summary>
    public class DataService
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 查询日订单文件
        public static void GetOrderDownloadsUrl()
        {
            // 实例化具体 API 对应的 request 类
            GetDailyOrderFileRequest request = new GetDailyOrderFileRequest();

            // 配置请求参数
            GetDailyOrderFileRequestModel model = new GetDailyOrderFileRequestModel
            {
                OrderDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetDailyOrderFileResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetDailyOrderFileResponseModel data = res.Data;
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

        // 查询日流水文件
        public static void GetDailyBillFileV2()
        {
            // 实例化具体 API 对应的 request 类
            GetDailyBillFileV2Request request = new GetDailyBillFileV2Request();

            // 配置请求参数
            GetDailyBillFileV2RequestModel model = new GetDailyBillFileV2RequestModel
            {
                BillDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetDailyBillFileV2Response res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetDailyBillFileV2ResponseModel data = res.Data;
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

        // 查询平台企业预付业务服务费记录
        public static void ListDealerRechargeRecordV2()
        {
            // 实例化具体 API 对应的 request 类
            ListDealerRechargeRecordV2Request request = new ListDealerRechargeRecordV2Request();

            // 配置请求参数
            ListDealerRechargeRecordV2RequestModel model = new ListDealerRechargeRecordV2RequestModel
            {
                BeginAt = "2022-03-23",
                EndAt = "2022-03-30",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDealerRechargeRecordV2Response res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 处理成功
                    List<RechargeRecordInfo> data = res.Data;
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

        // 查询日订单数据
        public static void ListDailyOrder()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyOrderRequest request = new ListDailyOrderRequest();

            // 配置请求参数
            ListDailyOrderRequestModel model = new ListDailyOrderRequestModel
            {
                OrderDate = "2022-03-23",
                Offset = 0,
                Length = 100,
                Channel = "银行卡",
                DataType = "encryption",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDailyOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 处理成功
                    ListDailyOrderResponseModel data = res.Data;
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

        // 查询日订单文件（支付和退款订单）
        public static void GetDailyOrderFileV2()
        {
            // 实例化具体 API 对应的 request 类
            GetDailyOrderFileV2Request request = new GetDailyOrderFileV2Request();

            // 配置请求参数
            GetDailyOrderFileV2RequestModel model = new GetDailyOrderFileV2RequestModel
            {
                OrderDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetDailyOrderFileV2Response res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetDailyOrderFileV2ResponseModel data = res.Data;
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

        // 查询日流水数据
        public static void ListDailyBill()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyBillRequest request = new ListDailyBillRequest();

            // 配置请求参数
            ListDailyBillRequestModel model = new ListDailyBillRequestModel
            {
                BillDate = "2022-03-23",
                Offset = 0,
                Length = 100,
                DataType = "encryption",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDailyBillResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 处理成功
                    ListDailyBillResponseModel data = res.Data;
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

        // 查询余额日账单数据
        public static void ListBalanceDailyStatement()
        {
            // 实例化具体 API 对应的 request 类
            ListBalanceDailyStatementRequest request = new ListBalanceDailyStatementRequest();

            // 配置请求参数
            ListBalanceDailyStatementRequestModel model = new ListBalanceDailyStatementRequestModel
            {
                StatementDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListBalanceDailyStatementResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 处理成功
                    ListBalanceDailyStatementResponseModel data = res.Data;
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
