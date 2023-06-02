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

            // 加载接口参数
            GetDailyOrderFileRequestModel model = new GetDailyOrderFileRequestModel
            {
                OrderDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            GetDailyOrderFileResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetDailyOrderFileResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日流水文件
        public static void GetDailyBillFileV2()
        {
            // 实例化具体 API 对应的 request 类
            GetDailyBillFileV2Request request = new GetDailyBillFileV2Request();

            // 加载接口参数
            GetDailyBillFileV2RequestModel model = new GetDailyBillFileV2RequestModel
            {
                BillDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            GetDailyBillFileV2Response res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetDailyBillFileV2ResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询平台企业预付业务服务费记录
        public static void ListDealerRechargeRecordV2()
        {
            // 实例化具体 API 对应的 request 类
            ListDealerRechargeRecordV2Request request = new ListDealerRechargeRecordV2Request();

            // 加载接口参数
            ListDealerRechargeRecordV2RequestModel model = new ListDealerRechargeRecordV2RequestModel
            {
                BeginAt = "2022-03-23",
                EndAt = "2022-03-30",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            ListDealerRechargeRecordV2Response res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                List<RechargeRecordInfo> data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日订单数据
        public static void ListDailyOrder()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyOrderRequest request = new ListDailyOrderRequest();

            // 加载接口参数
            ListDailyOrderRequestModel model = new ListDailyOrderRequestModel
            {
                OrderDate = "2022-03-23",
                Offset = 0,
                Length = 100,
                Channel = "银行卡",
                DataType = "encryption",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            ListDailyOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ListDailyOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日订单文件（支付和退款订单）
        public static void GetDailyOrderFileV2()
        {
            // 实例化具体 API 对应的 request 类
            GetDailyOrderFileV2Request request = new GetDailyOrderFileV2Request();

            // 加载接口参数
            GetDailyOrderFileV2RequestModel model = new GetDailyOrderFileV2RequestModel
            {
                OrderDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            GetDailyOrderFileV2Response res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetDailyOrderFileV2ResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日流水数据
        public static void ListDailyBill()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyBillRequest request = new ListDailyBillRequest();

            // 加载接口参数
            ListDailyBillRequestModel model = new ListDailyBillRequestModel
            {
                BillDate = "2022-03-23",
                Offset = 0,
                Length = 100,
                DataType = "encryption",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            ListDailyBillResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ListDailyBillResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询余额日账单数据
        public static void ListBalanceDailyStatement()
        {
            // 实例化具体 API 对应的 request 类
            ListBalanceDailyStatementRequest request = new ListBalanceDailyStatementRequest();

            // 加载接口参数
            ListBalanceDailyStatementRequestModel model = new ListBalanceDailyStatementRequestModel
            {
                StatementDate = "2022-03-23",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            ListBalanceDailyStatementResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ListBalanceDailyStatementResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}
