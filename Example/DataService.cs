﻿using System;
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
        /// <summary>
        /// 获取基础配置信息
        /// </summary>
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        /// <summary>
        /// 客户端实现
        /// </summary>
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        /// <summary>
        /// 查询日订单文件
        /// </summary>
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

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetDailyOrderFileResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
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

        /// <summary>
        /// 查询日流水文件
        /// </summary>
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

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetDailyBillFileV2Response res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
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

        /// <summary>
        /// 查询平台企业预付业务服务费记录
        /// </summary>
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

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDealerRechargeRecordV2Response res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
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

        /// <summary>
        /// 查询日订单数据
        /// </summary>
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

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDailyOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
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

         /// <summary>
        /// 查询日订单数据（支付和退款订单）
        /// </summary>
        public static void ListDailyOrderV2()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyOrderV2Request request = new ListDailyOrderV2Request();

            // 配置请求参数
            ListDailyOrderV2RequestModel model = new ListDailyOrderV2RequestModel
            {
                OrderDate = "2024-09-05",
                Offset = 0,
                Length = 100,
                Channel = "alipay",
                DataType = "",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDailyOrderV2Response res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ListDailyOrderV2ResponseModel data = res.Data;
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
        /// 查询日订单文件（支付和退款订单）
        /// </summary>
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

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetDailyOrderFileV2Response res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
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

        /// <summary>
        /// 查询日流水数据
        /// </summary>
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

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDailyBillResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
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

        /// <summary>
        /// 查询余额日账单数据
        /// </summary>
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

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListBalanceDailyStatementResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
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

        /// <summary>
        /// 查询日订单汇总数据
        /// </summary>
        public static void ListDailyOrderSummary()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyOrderSummaryRequest request = new ListDailyOrderSummaryRequest();

            // 配置请求参数
            ListDailyOrderSummaryRequestModel model = new ListDailyOrderSummaryRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Channel = "支付宝",
                BeginAt = "2025-02-01",
                EndAt = "2025-02-07",
                FilterType = "apply",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListDailyOrderSummaryResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ListDailyOrderSummaryResponseModel data = res.Data;
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
        /// 查询月订单汇总数据
        /// </summary>
        public static void ListMonthlyOrderSummary()
        {
            // 实例化具体 API 对应的 request 类
            ListMonthlyOrderSummaryRequest request = new ListMonthlyOrderSummaryRequest();

            // 配置请求参数
            ListMonthlyOrderSummaryRequestModel model = new ListMonthlyOrderSummaryRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Channel = "银行卡",
                Month = "2025-01",
                FilterType = "apply",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListMonthlyOrderSummaryResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ListMonthlyOrderSummaryResponseModel data = res.Data;
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
