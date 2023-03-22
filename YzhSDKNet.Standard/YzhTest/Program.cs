using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.config;

namespace YzhTest
{
    class Program
    {
        // 获取基础配置信息
        static YzhConfig config = ConfigUtil.GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        

        static void Main(string[] args){
            CreateAlipayOrder_Example();
            //GetOrder_Example();
        }

        // 下载个人所得税扣缴明细表
        public static void GetTaxFile_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetTaxFileRequest request = new GetTaxFileRequest();
            // 加载接口参数
            GetTaxFileRequestModel model = new GetTaxFileRequestModel
            {
                DealerID = config.DealerID,
                EntID = "accumulus_tj",
                YearMonth = "2023-01"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetTaxFileResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询纳税人是否为跨集团用户
        public static void GetUserCross_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetUserCrossRequest request = new GetUserCrossRequest();
            // 加载接口参数
            GetUserCrossRequestModel model = new GetUserCrossRequestModel
            {
                DealerID = config.DealerID,
                EntID = "accumulus_tj",
                Year = "2023",
                IDCard = "110101198010021201"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetUserCrossResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 银行卡实时支付
        public static void CreateBankpayOrder_Example()
        { 
            // 实例化具体 API 对应的 request 类
            CreateBankpayOrderRequest request = new CreateBankpayOrderRequest();
            // 加载接口参数
            CreateBankpayOrderRequestModel model = new CreateBankpayOrderRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                OrderID = "test20230307003",
                RealName = "高斯寒",
                IDCard = "210921199003101415",
                CardNo = "6214830180870857",
                PhoneNo = "",
                Pay = "9.99",
                PayRemark = "测试备注",
                NotifyURL = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateBankpayOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 支付宝实时支付
        public static void CreateAlipayOrder_Example()
        { 

            // 实例化具体 API 对应的 request 类
            CreateAlipayOrderRequest request = new CreateAlipayOrderRequest();
            // 加载接口参数
            CreateAlipayOrderRequestModel model = new CreateAlipayOrderRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                OrderID = "test20230307008",
                RealName = "高斯寒",
                IDCard = "210921199003101415",
                CardNo = "17600957177",
                PhoneNo = "",
                Pay = "1.00",
                PayRemark = "测试备注",
                NotifyURL = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateAlipayOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 微信实时支付
        public static void CreateWxpayOrder_Example()
        { 

            // 实例化具体 API 对应的 request 类
            CreateWxpayOrderRequest request = new CreateWxpayOrderRequest();
            // 加载接口参数
            CreateWxpayOrderRequestModel model = new CreateWxpayOrderRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                Openid = "dakdfe123121",
                WxAppID = "",
                PhoneNo = "",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateWxpayOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 批次下单
        public static void CreateBatchOrder_Example()
        { 

            // 实例化具体 API 对应的 request 类
            CreateBatchOrderRequest request = new CreateBatchOrderRequest();
            // 加载接口参数
            CreateBatchOrderRequestModel model = new CreateBatchOrderRequestModel
            {
                BatchID = "test12321332",
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Channel = "银行卡",
                TotalPay = "100.00",
                TotalCount = "3",
                OrderList = new BatchOrderInfo[] {new BatchOrderInfo{
                    OrderID = "test1234567890",
                    RealName = "张三",
                    IDCard = "110101198012021002",
                    CardNo = "dakdfe123121",
                    PhoneNo = "",
                    Pay = "30.00",
                    PayRemark = "测试备注",
                    NotifyURL = ""
                },new BatchOrderInfo{
                    OrderID = "test1234567891",
                    RealName = "李四",
                    IDCard = "110101198012021003",
                    CardNo = "dakdfe123122",
                    PhoneNo = "",
                    Pay = "20.00",
                    PayRemark = "测试备注",
                    NotifyURL = ""
                },new BatchOrderInfo{
                    OrderID = "test1234567892",
                    RealName = "王五",
                    IDCard = "110101198012021004",
                    CardNo = "dakdfe123123",
                    PhoneNo = "",
                    Pay = "50.00",
                    PayRemark = "测试备注",
                    NotifyURL = ""
                }
                }
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateBatchOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 批次确认
        public static void ConfirmBatchOrder_Example()
        { 

            // 实例化具体 API 对应的 request 类
            ConfirmBatchOrderRequest request = new ConfirmBatchOrderRequest();
            // 加载接口参数
            ConfirmBatchOrderRequestModel model = new ConfirmBatchOrderRequestModel
            {
                BatchID = "b2321ewfada",
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Channel = "支付宝"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ConfirmBatchOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询单笔订单信息
        public static void GetOrder_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetOrderRequest request = new GetOrderRequest();
            // 加载接口参数
            GetOrderRequestModel model = new GetOrderRequestModel
            {
                OrderID = "test20230307003",
                Channel = "银行卡",
                DataType = "encryption"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询平台企业余额
        public static void ListAccount_Example()
        { 

            // 实例化具体 API 对应的 request 类
            ListAccountRequest request = new ListAccountRequest();
            // 加载接口参数
            ListAccountRequestModel model = new ListAccountRequestModel
            {
                DealerID = config.DealerID
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListAccountResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询电子回单
        public static void GetEleReceiptFile_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetEleReceiptFileRequest request = new GetEleReceiptFileRequest();
            // 加载接口参数
            GetEleReceiptFileRequestModel model = new GetEleReceiptFileRequestModel
            {
                OrderID = "12312312421321",
                Ref = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetEleReceiptFileResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 取消待支付订单
        public static void CancelOrder_Example()
        { 

            // 实例化具体 API 对应的 request 类
            CancelOrderRequest request = new CancelOrderRequest();
            // 加载接口参数
            CancelOrderRequestModel model = new CancelOrderRequestModel
            {
                DealerID = config.DealerID,
                OrderID = "12312312421321",
                Ref = "",
                Channel = "银行卡"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CancelOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询平台企业汇款信息
        public static void GetDealerVARechargeAccount_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetDealerVARechargeAccountRequest request = new GetDealerVARechargeAccountRequest();
            // 加载接口参数
            GetDealerVARechargeAccountRequestModel model = new GetDealerVARechargeAccountRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDealerVARechargeAccountResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询平台企业已开具和待开具发票金额
        public static void GetInvoiceStat_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceStatRequest request = new GetInvoiceStatRequest();
            // 加载接口参数
            GetInvoiceStatRequestModel model = new GetInvoiceStatRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Year = 2023
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceStatResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询可开具发票额度和发票开具信息
        public static void GetInvoiceAmount_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceAmountRequest request = new GetInvoiceAmountRequest();
            // 加载接口参数
            GetInvoiceAmountRequestModel model = new GetInvoiceAmountRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceAmountResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 发票开具申请
        public static void ApplyInvoice_Example()
        { 

            // 实例化具体 API 对应的 request 类
            ApplyInvoiceRequest request = new ApplyInvoiceRequest();
            // 加载接口参数
            ApplyInvoiceRequestModel model = new ApplyInvoiceRequestModel
            {
                InvoiceApplyID = "1231232131",
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Amount = "100000.00",
                InvoiceType = "1",
                BankNameAccount = "交通银行北京东大桥支行 12343456654321",
                GoodsServicesName = "信息技术服务*信息技术服务费",
                Remark = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApplyInvoiceResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询发票开具申请状态
        public static void GetInvoiceStatus_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceStatusRequest request = new GetInvoiceStatusRequest();
            // 加载接口参数
            GetInvoiceStatusRequestModel model = new GetInvoiceStatusRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 下载 PDF 版发票
        public static void GetInvoiceFile_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceFileRequest request = new GetInvoiceFileRequest();
            // 加载接口参数
            GetInvoiceFileRequestModel model = new GetInvoiceFileRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceFileResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 发送发票扫描件压缩包下载链接邮件
        public static void SendReminderEmail_Example()
        { 

            // 实例化具体 API 对应的 request 类
            SendReminderEmailRequest request = new SendReminderEmailRequest();
            // 加载接口参数
            SendReminderEmailRequestModel model = new SendReminderEmailRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            SendReminderEmailResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // H5 预申请签约
        public static void H5UserPresign_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5UserPresignRequest request = new H5UserPresignRequest();
            // 加载接口参数
            H5UserPresignRequestModel model = new H5UserPresignRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "1102321742183272",
                CertificateType = 0
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserPresignResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // H5 申请签约
        public static void H5UserSign_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5UserSignRequest request = new H5UserSignRequest();
            // 加载接口参数
            H5UserSignRequestModel model = new H5UserSignRequestModel
            {
                Token = "1231231jdfalrejia",
                Color = "#8171ff",
                URL = "http://www.abcdef.com/api/notify",
                RedirectURL = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserSignResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 获取用户签约状态
        public static void GeH5UserSignStatus_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetH5UserSignStatusRequest request = new GetH5UserSignStatusRequest();
            // 加载接口参数
            GetH5UserSignStatusRequestModel model = new GetH5UserSignStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "1233984756231232"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetH5UserSignStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // H5 对接测试解约接口
        public static void GetInvoiceStat_ExampleH5UserRelease_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5UserReleaseRequest request = new H5UserReleaseRequest();
            // 加载接口参数
            H5UserReleaseRequestModel model = new H5UserReleaseRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "1233984756231232",
                CertificateType = 0
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserReleaseResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询日订单文件
        public static void GetOrderDownloadsUrl_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetDailyOrderFileRequest request = new GetDailyOrderFileRequest();
            // 加载接口参数
            GetDailyOrderFileRequestModel model = new GetDailyOrderFileRequestModel
            {
                OrderDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyOrderFileResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询日流水文件
        public static void GetDailyBillFileV2_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetDailyBillFileV2Request request = new GetDailyBillFileV2Request();
            // 加载接口参数
            GetDailyBillFileV2RequestModel model = new GetDailyBillFileV2RequestModel
            {
                BillDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyBillFileV2Response res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询平台企业预付业务服务费记录
        public static void ListDealerRechargeRecordV2_Example()
        { 

            // 实例化具体 API 对应的 request 类
            ListDealerRechargeRecordV2Request request = new ListDealerRechargeRecordV2Request();
            // 加载接口参数
            ListDealerRechargeRecordV2RequestModel model = new ListDealerRechargeRecordV2RequestModel
            {
                BeginAt = "2022-03-23",
                EndAt = "2022-03-30"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDealerRechargeRecordV2Response res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询日订单数据
        public static void ListDailyOrder_Example()
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
                DataType = "encryption"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDailyOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询日流水数据
        public static void ListDailyBill_Example()
        { 

            // 实例化具体 API 对应的 request 类
            ListDailyBillRequest request = new ListDailyBillRequest();
            // 加载接口参数
            ListDailyBillRequestModel model = new ListDailyBillRequestModel
            {
                BillDate = "2022-03-23",
                Offset = 0,
                Length = 100,
                DataType = "encryption"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDailyBillResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询日订单文件（支付和退款订单）
        public static void GetDailyOrderFileV2_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetDailyOrderFileV2Request request = new GetDailyOrderFileV2Request();
            // 加载接口参数
            GetDailyOrderFileV2RequestModel model = new GetDailyOrderFileV2RequestModel
            {
                OrderDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyOrderFileV2Response res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询余额日账单数据
        public static void ListBalanceDailyStatement_Example()
        { 

            // 实例化具体 API 对应的 request 类
            ListBalanceDailyStatementRequest request = new ListBalanceDailyStatementRequest();
            // 加载接口参数
            ListBalanceDailyStatementRequestModel model = new ListBalanceDailyStatementRequestModel
            {
                StatementDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListBalanceDailyStatementResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 工商实名信息录入
        public static void H5PreCollectBizlicMsg_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5PreCollectBizlicMsgRequest request = new H5PreCollectBizlicMsgRequest();
            // 加载接口参数
            H5PreCollectBizlicMsgRequestModel model = new H5PreCollectBizlicMsgRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                PhoneNo = "",
                IDCard = "110101198010211423",
                RealName = "张三",
                IDCardAddress = "北京市朝阳区",
                IDCardAgency = "北京市朝阳区派出所",
                IDCardNation = "20",
                IDCardValidityStart = "2020-10-01",
                IDCardValidityEnd = "2040-10-01"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5PreCollectBizlicMsgResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 预启动
        public static void H5APIGetStartUrl_Example()
        {
            // 实例化具体 API 对应的 request 类
            H5APIGetStartUrlRequest request = new H5APIGetStartUrlRequest();
            // 加载接口参数
            H5APIGetStartUrlRequestModel model = new H5APIGetStartUrlRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                ClientType = 2,
                NotifyURL = "http://www.abcdef.com/api/notify",
                Color = "#007AFF",
                ReturnURL = "",
                CustomerTitle = 1
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5APIGetStartUrlResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 查询个体工商户状态
        public static void H5APIEcoCityAicStatus_Example()
        {

            // 实例化具体 API 对应的 request 类
            H5APIEcoCityAicStatusRequest request = new H5APIEcoCityAicStatusRequest();
            // 加载接口参数
            H5APIEcoCityAicStatusRequestModel model = new H5APIEcoCityAicStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                RealName = "张三",
                IDCard = "110101198010211242",
                OpenID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5APIEcoCityAicStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //预启动
        public static void H5GetStartUrl_Example()
        {

            // 实例化具体 API 对应的 request 类
            H5GetStartUrlRequest request = new H5GetStartUrlRequest();
            // 加载接口参数
            H5GetStartUrlRequestModel model = new H5GetStartUrlRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                ClientType = 1,
                NotifyURL = "http://www.abcdef.com/api/notify",
                Color = "#007AFF",
                ReturnURL = "",
                CustomerTitle = 1
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5GetStartUrlResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //查询个体工商户状态
        public static void H5EcoCityAicStatus_Example()
        {

            // 实例化具体 API 对应的 request 类
            H5EcoCityAicStatusRequest request = new H5EcoCityAicStatusRequest();
            // 加载接口参数
            H5EcoCityAicStatusRequestModel model = new H5EcoCityAicStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                RealName = "张三",
                IDCard = "110101198010211242",
                OpenID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5EcoCityAicStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 身份实名验证
        public static void IDCardVerify_Example()
        {

            // 实例化具体 API 对应的 request 类
            IDCardVerifyRequest request = new IDCardVerifyRequest();
            // 加载接口参数
            IDCardVerifyRequestModel model = new IDCardVerifyRequestModel
            {
                IDCard = "110101198001221211",
                RealName = "张三"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            IDCardVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 银行卡信息查询
        public static void GetBankCardInfo_Example()
        {

            // 实例化具体 API 对应的 request 类
            GetBankCardInfoRequest request = new GetBankCardInfoRequest();
            // 加载接口参数
            GetBankCardInfoRequestModel model = new GetBankCardInfoRequestModel
            {
                CardNo = "1234568987645212321",
                BankName = "招商银行"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetBankCardInfoResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //银行卡三要素验证
        public static void BankCardThreeVerify_Example()
        {

            // 实例化具体 API 对应的 request 类
            BankCardThreeVerifyRequest request = new BankCardThreeVerifyRequest();
            // 加载接口参数
            BankCardThreeVerifyRequestModel model = new BankCardThreeVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardThreeVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //银行卡四要素验证
        public static void BankCardFourVerify_Example()
        {

            // 实例化具体 API 对应的 request 类
            BankCardFourVerifyRequest request = new BankCardFourVerifyRequest();
            // 加载接口参数
            BankCardFourVerifyRequestModel model = new BankCardFourVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //银行卡四要素鉴权请求（下发短信验证码）
        public static void BankCardFourAuthVerify_Example()
        {

            // 实例化具体 API 对应的 request 类
            BankCardFourAuthVerifyRequest request = new BankCardFourAuthVerifyRequest();
            // 加载接口参数
            BankCardFourAuthVerifyRequestModel model = new BankCardFourAuthVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourAuthVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //银行卡四要素确认请求（上传短信验证码）
        public static void BankCardFourAuthConfirm_Example()
        {

            // 实例化具体 API 对应的 request 类
            BankCardFourAuthConfirmRequest request = new BankCardFourAuthConfirmRequest();
            // 加载接口参数
            BankCardFourAuthConfirmRequestModel model = new BankCardFourAuthConfirmRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888",
                Captcha = "12345",
                Ref = "1234567890"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourAuthConfirmResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //上传免验证用户名单信息
        public static void UserExemptedInfo_Example()
        {

            // 实例化具体 API 对应的 request 类
            UserExemptedInfoRequest request = new UserExemptedInfoRequest();
            // 加载接口参数
            UserExemptedInfoRequestModel model = new UserExemptedInfoRequestModel
            {
                // 姓名
                RealName = "张三",
                // 证件号码
                IDCard = "M101198001201232",
                // 证件类型
                CardType = "passport",
                // 申请备注
                CommentApply = "申请免验证名单",
                // 平台企业 ID
                DealerID = config.DealerID,
                // 综合服务主体 ID
                BrokerID = config.BrokerID,
                // 证件照图片进行 Base64 编码后的字符串
                UserImages = new string[] { "igngudaere", "dfafdaea" },
                // 国别（地区）代码
                Country = "NOR",
                // 出生日期
                Birthday = "20010809",
                // 性别
                Gender = "男",
                // 审核完成后，接收异步通知的地址
                NotifyURL = "http://www.abcdef.com/api/notify",
                // 唯一流水号，回调时会附带
                Ref = "1234567890"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            UserExemptedInfoResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        //查看免验证用户名单是否存在
        public static void UserWhiteCheck_Example()
        {

            // 实例化具体 API 对应的 request 类
            UserWhiteCheckRequest request = new UserWhiteCheckRequest();
            // 加载接口参数
            UserWhiteCheckRequestModel model = new UserWhiteCheckRequestModel
            {
                RealName = "张三",
                IDCard = "M101198001201232",
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            UserWhiteCheckResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 获取协议预览 URL
        public static void ApiUseSignContract_Example()
        {
            // 实例化具体 API 对应的 request 类
            ApiUseSignContractRequest request = new ApiUseSignContractRequest();
            // 加载接口参数
            ApiUseSignContractRequestModel model = new ApiUseSignContractRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUseSignContractResponse res = client.Execute(request);
            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 用户签约
        public static void ApiUserSign_Example()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignRequest request = new ApiUserSignRequest();
            // 加载接口参数
            ApiUserSignRequestModel model = new ApiUserSignRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "高斯寒",
                IDCard = "210921199003101415",
                CardType = "idcard"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUserSignResponse res = client.Execute(request);
            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 获取用户签约状态
        public static void GetApiUserSignStatus_Example()
        {
            // 实例化具体 API 对应的 request 类
            GetApiUserSignStatusRequest request = new GetApiUserSignStatusRequest();
            // 加载接口参数
            GetApiUserSignStatusRequestModel model = new GetApiUserSignStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetApiUserSignStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        // 用户解约（测试账号专用）
        public static void ApiUserSignRelease_Example()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignReleaseRequest request = new ApiUserSignReleaseRequest();
            // 加载接口参数
            ApiUserSignReleaseRequestModel model = new ApiUserSignReleaseRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "210110199001011212",
                CardType = "idcard"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 
            
            // 发起请求
            ApiUserSignReleaseResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 根据响应码进行业务处理
            }
            else
            {
                // 处理返回异常情况
            }
        }

        
    }
}
