using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class Payment
    {
        //获取基础配置信息
        public static YzhConfig GetConfig()
        {
            YzhConfig config = new YzhConfig();
            config.ServerUrl = ""; //设置接口基础地址
            config.DealerID = ""; //设置平台企业 ID
            config.BrokerID = ""; //设置综合服务主体 ID
            config.AppKey = ""; //设置 App Key
            config.PrivateKey = ""; //设置平台企业私钥
            config.YzhPublicKey = ""; //设置云账户公钥
            config.Des3Key = ""; //设置 3DES Key
            config.SignType = ""; //设置签名方式，RSA 或 SHA256

            return config;

        }

        //银行卡实时支付
        public void CreateBankpayOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new CreateBankpayOrderRequest();
            //加载接口参数
            var model = new CreateBankpayOrderRequestModel
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
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //支付宝实时支付
        public void CreateAlipayOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new CreateAlipayOrderRequest();
            //加载接口参数
            var model = new CreateAlipayOrderRequestModel
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
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //微信实时支付
        public void CreateWxpayOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new CreateWxpayOrderRequest();
            //加载接口参数
            var model = new CreateWxpayOrderRequestModel
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
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //批次下单
        public void CreateBatchOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new CreateBatchOrderRequest();
            //加载接口参数
            var model = new CreateBatchOrderRequestModel
            {
                BatchID = "test12321332",
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Channel = "银行卡",
                TotalPay = "100.00",
                TotalCount = "3",
                OrderList= new BatchOrderInfo[] {new BatchOrderInfo{
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
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //批次确认
        public void ConfirmBatchOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new ConfirmBatchOrderRequest();
            //加载接口参数
            var model = new ConfirmBatchOrderRequestModel
            {
                BatchID = "test12321332",
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Channel = "银行卡"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //查询单笔订单信息
        public void GetOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetOrderRequest();
            //加载接口参数
            var model = new GetOrderRequestModel
            {
                OrderID = "123123142718321",
                Channel = "银行卡",
                DataType = "encryption"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //查询平台企业余额
        public void ListAccount_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new ListAccountRequest();
            //加载接口参数
            var model = new ListAccountRequestModel
            {
                DealerID = config.DealerID
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //查询电子回单
        public void GetEleReceiptFile_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetEleReceiptFileRequest();
            //加载接口参数
            var model = new GetEleReceiptFileRequestModel
            {
                OrderID = "12312312421321",
                Ref = ""
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //取消待支付订单
        public void CancelOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new CancelOrderRequest();
            //加载接口参数
            var model = new CancelOrderRequestModel
            {
                DealerID = config.DealerID,
                OrderID = "12312312421321",
                Ref = "",
                Channel = "银行卡"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //查询平台企业汇款信息
        public void GetDealerVARechargeAccount_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetDealerVARechargeAccountRequest();
            //加载接口参数
            var model = new GetDealerVARechargeAccountRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }
    }
}
