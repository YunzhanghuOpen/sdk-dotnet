using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 实时支付
    /// </summary>
    public class Payment
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 银行卡实时支付
        public static void CreateBankpayOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateBankpayOrderRequest request = new CreateBankpayOrderRequest();

            // 加载接口参数
            CreateBankpayOrderRequestModel model = new CreateBankpayOrderRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                CardNo = "231326472361746231",
                PhoneNo = "18888888888",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = "http://www.abcdef.com/api/notify",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            CreateBankpayOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                CreateBankpayOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 支付宝实时支付
        public static void CreateAlipayOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateAlipayOrderRequest request = new CreateAlipayOrderRequest();

            // 加载接口参数
            CreateAlipayOrderRequestModel model = new CreateAlipayOrderRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                CardNo = "231326472361746231",
                PhoneNo = "18888888888",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = "http://www.abcdef.com/api/notify",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            CreateAlipayOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                CreateAlipayOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 微信实时支付
        public static void CreateWxpayOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateWxpayOrderRequest request = new CreateWxpayOrderRequest();

            // 加载接口参数
            CreateWxpayOrderRequestModel model = new CreateWxpayOrderRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                Openid = "dakdfe123121",
                WxAppID = "wxsaiIdjfei",
                PhoneNo = "18888888888",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = "http://www.abcdef.com/api/notify",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            CreateWxpayOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                CreateWxpayOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 批次下单
        public static void CreateBatchOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateBatchOrderRequest request = new CreateBatchOrderRequest();

            // 加载接口参数
            CreateBatchOrderRequestModel model = new CreateBatchOrderRequestModel
            {
                BatchID = "test20230418001",
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Channel = "银行卡",
                TotalPay = "10.00",
                TotalCount = "3",
                OrderList = new BatchOrderInfo[]
                {
                    new BatchOrderInfo
                    {
                    OrderID = "test202304180011",
                    RealName = "张三",
                    IDCard = "110101198012021002",
                    CardNo = "dakdfe123121",
                    PhoneNo = "16666666666",
                    Pay = "3.00",
                    PayRemark = "测试备注",
                    NotifyURL = "http://www.abcdef.com/api/notify",
                    }, new BatchOrderInfo
                    {
                    OrderID = "test202304180012",
                    RealName = "李四",
                    IDCard = "110101198012021003",
                    CardNo = "dakdfe123122",
                    PhoneNo = "17777777777",
                    Pay = "2.00",
                    PayRemark = "测试备注",
                    NotifyURL = "http://www.abcdef.com/api/notify",
                    }, new BatchOrderInfo
                    {
                    OrderID = "test202304180013",
                    RealName = "王五",
                    IDCard = "110101198012021004",
                    CardNo = "dakdfe123123",
                    PhoneNo = "18888888888",
                    Pay = "5.00",
                    PayRemark = "测试备注",
                    NotifyURL = "http://www.abcdef.com/api/notify",
                    },
                },
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            CreateBatchOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                CreateBatchOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 批次确认
        public static void ConfirmBatchOrder()
        {
            // 实例化具体 API 对应的 request 类
            ConfirmBatchOrderRequest request = new ConfirmBatchOrderRequest();

            // 加载接口参数
            ConfirmBatchOrderRequestModel model = new ConfirmBatchOrderRequestModel
            {
                BatchID = "b2321ewfada",
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Channel = "支付宝",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            ConfirmBatchOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ConfirmBatchOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询单笔订单信息
        public static void GetOrder()
        {
            // 实例化具体 API 对应的 request 类
            GetOrderRequest request = new GetOrderRequest();
            // 加载接口参数
            GetOrderRequestModel model = new GetOrderRequestModel
            {
                OrderID = "123123142718321",
                Channel = "银行卡",
                DataType = "encryption",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            GetOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询平台企业余额
        public static void ListAccount()
        {
            // 实例化具体 API 对应的 request 类
            ListAccountRequest request = new ListAccountRequest();

            // 加载接口参数
            ListAccountRequestModel model = new ListAccountRequestModel
            {
                DealerID = Config.DealerID,
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            ListAccountResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ListAccountResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询电子回单
        public static void GetEleReceiptFile()
        {
            // 实例化具体 API 对应的 request 类
            GetEleReceiptFileRequest request = new GetEleReceiptFileRequest();

            // 加载接口参数
            GetEleReceiptFileRequestModel model = new GetEleReceiptFileRequestModel
            {
                OrderID = "12312312421321",
                Ref = "1234562312314231",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            GetEleReceiptFileResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetEleReceiptFileResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 取消待支付订单
        public static void CancelOrder()
        {
            // 实例化具体 API 对应的 request 类
            CancelOrderRequest request = new CancelOrderRequest();

            // 加载接口参数
            CancelOrderRequestModel model = new CancelOrderRequestModel
            {
                DealerID = Config.DealerID,
                OrderID = "12312312421321",
                Ref = "1234562312314231",
                Channel = "银行卡",
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            CancelOrderResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                CancelOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询平台企业汇款信息
        public static void GetDealerVARechargeAccount()
        {
            // 实例化具体 API 对应的 request 类
            GetDealerVARechargeAccountRequest request = new GetDealerVARechargeAccountRequest();

            // 加载接口参数
            GetDealerVARechargeAccountRequestModel model = new GetDealerVARechargeAccountRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
            };
            request.SetBizModel(model);

            // request-id：每次请求的唯一标识
            // 强烈建议平台企业自定义 request-id 并记录在日志中，如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义则使用 SDK 中的 Guid.NewGuid() 方法自动生成，注意：Guid.NewGuid() 方法不能保证全局唯一，可能会出现 ID 重复，推荐自行实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            GetDealerVARechargeAccountResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetDealerVARechargeAccountResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}
