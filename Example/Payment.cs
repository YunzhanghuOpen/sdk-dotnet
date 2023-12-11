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
        /// <summary>
        /// 获取基础配置信息
        /// </summary>
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        /// <summary>
        /// 客户端实现
        /// </summary>
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        /// <summary>
        /// 单笔支付（银行卡实时支付）
        /// </summary>
        public static void CreateBankpayOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateBankpayOrderRequest request = new CreateBankpayOrderRequest();

            // 配置请求参数
            CreateBankpayOrderRequestModel model = new CreateBankpayOrderRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                CardNo = "231326472361746231",
                PhoneNo = "188****8888",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = "https://www.example.com",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CreateBankpayOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CreateBankpayOrderResponseModel data = res.Data;
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
        /// 单笔支付（支付宝实时支付）
        /// </summary>
        public static void CreateAlipayOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateAlipayOrderRequest request = new CreateAlipayOrderRequest();

            // 配置请求参数
            CreateAlipayOrderRequestModel model = new CreateAlipayOrderRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                CardNo = "231326472361746231",
                PhoneNo = "188****8888",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = "https://www.example.com",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CreateAlipayOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CreateAlipayOrderResponseModel data = res.Data;
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
        /// 单笔支付（微信实时支付）
        /// </summary>
        public static void CreateWxpayOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateWxpayOrderRequest request = new CreateWxpayOrderRequest();

            // 配置请求参数
            CreateWxpayOrderRequestModel model = new CreateWxpayOrderRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                Openid = "dakdfe123121",
                WxAppID = "wxsaiIdjfei",
                PhoneNo = "188****8888",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = "https://www.example.com",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CreateWxpayOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CreateWxpayOrderResponseModel data = res.Data;
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
        /// 批量支付（批次下单）
        /// </summary>
        public static void CreateBatchOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateBatchOrderRequest request = new CreateBatchOrderRequest();

            // 配置请求参数
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
                    PhoneNo = "188****8888",
                    Pay = "3.00",
                    PayRemark = "测试备注",
                    NotifyURL = "https://www.example.com",
                    }, new BatchOrderInfo
                    {
                    OrderID = "test202304180012",
                    RealName = "李四",
                    IDCard = "110101198012021003",
                    CardNo = "dakdfe123122",
                    PhoneNo = "188****8888",
                    Pay = "2.00",
                    PayRemark = "测试备注",
                    NotifyURL = "https://www.example.com",
                    }, new BatchOrderInfo
                    {
                    OrderID = "test202304180013",
                    RealName = "王五",
                    IDCard = "110101198012021004",
                    CardNo = "dakdfe123123",
                    PhoneNo = "188****8888",
                    Pay = "5.00",
                    PayRemark = "测试备注",
                    NotifyURL = "https://www.example.com",
                    },
                },
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CreateBatchOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CreateBatchOrderResponseModel data = res.Data;
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
        /// 批量支付（批次确认）
        /// </summary>
        public static void ConfirmBatchOrder()
        {
            // 实例化具体 API 对应的 request 类
            ConfirmBatchOrderRequest request = new ConfirmBatchOrderRequest();

            // 配置请求参数
            ConfirmBatchOrderRequestModel model = new ConfirmBatchOrderRequestModel
            {
                BatchID = "test20230418001",
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Channel = "银行卡",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ConfirmBatchOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ConfirmBatchOrderResponseModel data = res.Data;
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
        /// 查询单笔订单信息
        /// </summary>
        public static void GetOrder()
        {
            // 实例化具体 API 对应的 request 类
            GetOrderRequest request = new GetOrderRequest();
            // 配置请求参数
            GetOrderRequestModel model = new GetOrderRequestModel
            {
                OrderID = "123123142718321",
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
                GetOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetOrderResponseModel data = res.Data;
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
        /// 查询平台企业余额
        /// </summary>
        public static void ListAccount()
        {
            // 实例化具体 API 对应的 request 类
            ListAccountRequest request = new ListAccountRequest();

            // 配置请求参数
            ListAccountRequestModel model = new ListAccountRequestModel
            {
                DealerID = Config.DealerID,
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ListAccountResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ListAccountResponseModel data = res.Data;
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
        /// 查询电子回单
        /// </summary>
        public static void GetEleReceiptFile()
        {
            // 实例化具体 API 对应的 request 类
            GetEleReceiptFileRequest request = new GetEleReceiptFileRequest();

            // 配置请求参数
            GetEleReceiptFileRequestModel model = new GetEleReceiptFileRequestModel
            {
                OrderID = "12312312421321",
                Ref = "1234562312314231",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetEleReceiptFileResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetEleReceiptFileResponseModel data = res.Data;
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
        /// 取消待支付订单
        /// </summary>
        public static void CancelOrder()
        {
            // 实例化具体 API 对应的 request 类
            CancelOrderRequest request = new CancelOrderRequest();

            // 配置请求参数
            CancelOrderRequestModel model = new CancelOrderRequestModel
            {
                DealerID = Config.DealerID,
                OrderID = "12312312421321",
                Ref = "1234562312314231",
                Channel = "银行卡",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CancelOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CancelOrderResponseModel data = res.Data;
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
        /// 查询批次订单信息
        /// </summary>
        public static void QueryBatchOrder()
        {
            // 实例化具体 API 对应的 request 类
            QueryBatchOrderRequest request = new QueryBatchOrderRequest();

            // 配置请求参数
            QueryBatchOrderRequestModel model = new QueryBatchOrderRequestModel
            {
                BatchID = "12312312421321",
                DealerID = Config.DealerID,
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                QueryBatchOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    QueryBatchOrderResponseModel data = res.Data;
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
        /// 批次撤销
        /// </summary>
        public static void CancelBatchOrder()
        {
            // 实例化具体 API 对应的 request 类
            CancelBatchOrderRequest request = new CancelBatchOrderRequest();

            // 配置请求参数
            CancelBatchOrderRequestModel model = new CancelBatchOrderRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                BatchID = "12312312421321",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CancelBatchOrderResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CancelBatchOrderResponseModel data = res.Data;
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
        /// 查询平台企业汇款信息
        /// </summary>
        public static void GetDealerVARechargeAccount()
        {
            // 实例化具体 API 对应的 request 类
            GetDealerVARechargeAccountRequest request = new GetDealerVARechargeAccountRequest();

            // 配置请求参数
            GetDealerVARechargeAccountRequestModel model = new GetDealerVARechargeAccountRequestModel
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
                GetDealerVARechargeAccountResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetDealerVARechargeAccountResponseModel data = res.Data;
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
