using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 实时支付
    /// </summary>
    public class Payment
    {
        // 获取基础配置信息
        static YzhConfig config = ConfigUtil.GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        
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
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                CardNo = "231326472361746231",
                PhoneNo = "",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateBankpayOrderResponse res = client.Execute(request);

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
        public static void CreateAlipayOrder_Example()
        {
            // 实例化具体 API 对应的 request 类
            CreateAlipayOrderRequest request = new CreateAlipayOrderRequest();
            // 加载接口参数
            CreateAlipayOrderRequestModel model = new CreateAlipayOrderRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                CardNo = "231326472361746231",
                PhoneNo = "",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateAlipayOrderResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateWxpayOrderResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CreateBatchOrderResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ConfirmBatchOrderResponse res = client.Execute(request);

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
        public static void GetOrder_Example()
        {
            // 实例化具体 API 对应的 request 类
            GetOrderRequest request = new GetOrderRequest();
            // 加载接口参数
            GetOrderRequestModel model = new GetOrderRequestModel
            {
                OrderID = "123123142718321",
                Channel = "银行卡",
                DataType = "encryption"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetOrderResponseModel data = res.Data;
                //根据接收到的数据进行后续业务处理
                switch (data.Status)
                {
                    case "1":
                        // 已支付（对于支付宝和微信支付是最终状态，对于银行卡大部分情况是终态，小概率会出现“退汇现象”，状态由“成功”变为“退汇”）
                        // TODO 更新业务订单状态,提示用户提现成功
                        break;
                    case "2":
                        // 失败（最终状态）
                        // TODO 更新业务订单状态,提示用户提现失败，若有用户钱包体系，则需将提现金额退回至用户钱包
                        break;
                    case "4":
                        // 订单挂起（中间状态，挂起原因会在订单详细状态信息返回）
                        // TODO 提示用户提现中，其他逻辑如：若因余额不足导致的订单挂起，可通知财务及时预付业务服务费，72 小时内补足余额后可自动继续支付，切勿将订单挂起当做失败处理
                        break;
                    case "9":
                        // 退汇失败（最终状态，银行卡支付路径特有现象，收到“成功”回调后，再收到“退汇”的回调，一般与成功状态间隔 24 小时以上）
                        // TODO 更新业务订单状态为“退汇”（失败），通知用户提现失败，建议用户更换其他银行卡提现，若有用户钱包体系，则需将提现金额退回至用户钱包
                        break;
                    case "15":
                        // 订单取消（最终状态，只有订单挂起的订单才可以取消）
                        // TODO 更新业务订单状态为“取消”（失败，通知用户提现失败，若有用户钱包体系，则需将提现金额退回至用户钱包
                        break;
                }
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListAccountResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetEleReceiptFileResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            CancelOrderResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDealerVARechargeAccountResponse res = client.Execute(request);

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
