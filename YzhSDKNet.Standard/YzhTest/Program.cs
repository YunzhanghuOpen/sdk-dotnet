using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.config;
using System.Collections.Generic;

namespace YzhTest
{
    class Program
    {
        // 获取基础配置信息
        static YzhConfig config = ConfigUtil.GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        

        static void Main(string[] args){
            NotifyH5EcoCityAic_Example();
            //GetOrder_Example();
        }

        // 发票开局完成回调
        public static void NotifyInvoiceDone_Example()
        {

            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyInvoiceDoneRequestModel> request = new YzhCallbackRequest<NotifyInvoiceDoneRequestModel>()
            {
                Data = "7fvB7MGlR23JNwL4EUEEkdttfvFMGMlNNlIRiyHfopWa0H4tWor4zJdR6QGd6LqJZaD/2WeU0m/GI4rCIgYwnFL3AdNoSmAnLQ2uKyVfOm3iey96o55a00mnqex8/kFwuvo7Vi6rTRUZDD4mfOm4eY4JCVfH/i7/6ltPdtIWZCM=",
                Mess = "2489",
                Timestamp = "1679986064",
                Sign = "x6bDf/MSd3Nahc+0V/OuY1QGzzVirs3ZfHmAQY0jlAIpxm1CcI5kL6bAhm9L3wROGwrKTh8kC5YBFcUm8gxVBfFCR5XQYAkhaSeAmdE+ARBN9UxU6GpeAT+ZZOe4lSgCsMAGRRMtwdIYIAerw+PFU+la96L4pnE7cxfJZVt24zc=",
                SignType = "rsa"
            };

            // 发起解密验签
            NotifyInvoiceDoneRequestModel res = client.CallBackExecute(request);

            // 根据接收到的数据进行后续业务处理
            if (res.Status == "3")
            {
                // 发票已邮寄，处理后续业务
            }
            else
            {
                // 发票驳回
                Console.WriteLine("发票驳回原因：" + res.RejectReason);
            }
        }

        // 个体工商户注册结果回调
        public static void NotifyH5EcoCityAic_Example()
        {

            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyH5EcoCityAicRequestModel> request = new YzhCallbackRequest<NotifyH5EcoCityAicRequestModel>()
            {
                Data = "7fvB7MGlR23JNwL4EUEEkdttfvFMGMlNNlIRiyHfopWa0H4tWor4zJdR6QGd6LqJZaD/2WeU0m/GI4rCIgYwnFL3AdNoSmAnLQ2uKyVfOm3iey96o55a00mnqex8/kFwuvo7Vi6rTRUZDD4mfOm4eY4JCVfH/i7/6ltPdtIWZCM=",
                Mess = "2489",
                Timestamp = "1679986064",
                Sign = "x6bDf/MSd3Nahc+0V/OuY1QGzzVirs3ZfHmAQY0jlAIpxm1CcI5kL6bAhm9L3wROGwrKTh8kC5YBFcUm8gxVBfFCR5XQYAkhaSeAmdE+ARBN9UxU6GpeAT+ZZOe4lSgCsMAGRRMtwdIYIAerw+PFU+la96L4pnE7cxfJZVt24zc=",
                SignType = "rsa"
            };

            // 发起解密验签
            NotifyH5EcoCityAicRequestModel res = client.CallBackExecute(request);

            // 根据接收到的数据进行后续业务处理
            if (res.Status == 6)
            {
                // 税务登记成功，可向用户进行支付
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("用户姓名：" + res.RealName + "\n个体户注册状态码：" + res.Status + "\n个体户注册状态吗描述：" + res.StatusMessage);
            }
        }

        // H5 签约回调
        public static void NotifyH5UserSign_Example()
        {

            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyH5UserSignRequestModel> request = new YzhCallbackRequest<NotifyH5UserSignRequestModel>()
            {
                Data = "7fvB7MGlR23JNwL4EUEEkdttfvFMGMlNNlIRiyHfopWa0H4tWor4zJdR6QGd6LqJZaD/2WeU0m/GI4rCIgYwnFL3AdNoSmAnLQ2uKyVfOm3iey96o55a00mnqex8/kFwuvo7Vi6rTRUZDD4mfOm4eY4JCVfH/i7/6ltPdtIWZCM=",
                Mess = "2489",
                Timestamp = "1679986064",
                Sign = "x6bDf/MSd3Nahc+0V/OuY1QGzzVirs3ZfHmAQY0jlAIpxm1CcI5kL6bAhm9L3wROGwrKTh8kC5YBFcUm8gxVBfFCR5XQYAkhaSeAmdE+ARBN9UxU6GpeAT+ZZOe4lSgCsMAGRRMtwdIYIAerw+PFU+la96L4pnE7cxfJZVt24zc=",
                SignType = "rsa"
            };

            // 发起解密验签
            NotifyH5UserSignRequestModel res = client.CallBackExecute(request);

            // 根据回调信息处理
            Console.WriteLine("用户姓名：" + res.RealName + "\n证件号：" + res.IDCard);
        }

        // 免验证名单审核结果回调通知
        public static void NotifyUserExemptedInfo_Example()
        {

            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyUserExemptedInfoRequestModel> request = new YzhCallbackRequest<NotifyUserExemptedInfoRequestModel>()
            {
                Data = "7fvB7MGlR23JNwL4EUEEkdttfvFMGMlNNlIRiyHfopWa0H4tWor4zJdR6QGd6LqJZaD/2WeU0m+X/RIj0Ic2dg5eCWCTJarLf9xIZerZpFuNnFbcl8gRdXKOB4aRrKUBThgAsLgD8a5fEN/BA9xPotdAUBhmVQfKMbijkaObWac31ogsTiAfZ7dY5VIfbov6gRBvVDHGCkU=",
                Mess = "839427091",
                Timestamp = "1676446701",
                Sign = "mn63bWcBXdDbCFDSWAXKt86HVuXQd4Gat3q4bAHyJFG5abnfi5GAUDHsXTs03nCX1QFEsC/DwIoKuJGfgnS7DeLGepV87u0YSxZhgsSsJmj95Hmo2YtjsmP8qvMapDWh0U/p/jskU7P7K9/Yc93qvk04PyUNjYqfebckM4o0vIo=",
                SignType = "rsa"
            };

            // 发起解密验签
            NotifyUserExemptedInfoRequestModel res = client.CallBackExecute(request);
            
            // 根据接收到的数据进行后续业务处理
            if (res.Status == "pass")
            {
                // 审核通过，进行后续业务处理
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("用户姓名：" + res.RealName + "\n审核信息：" + res.Comment);
            }
        }

        // 订单回调验签解密
        public static void NotifyOrderData_Example()
        {

            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyOrderRequestModel> request = new YzhCallbackRequest<NotifyOrderRequestModel>()
            {
                Data = "9i1F/I3xHanUcgXgPpZyd2YfLiTtpqtJArOFKdeG4J3vQmoGl5HjcSW7x2drsh7t95I7oRmpQAZdFsOeyxKIc7hT+lRqMo1drlDf3/mjunw0BO+ZB+6Vb1eiTA0IyKzHVSbhX/nXw6hDpMkvLOSGpnkcYnO/gYRAZu+xBZllUoezUzizLnLp3Jl1dYFRuG/Rplm1vJlo7DGnrwPWuDGRtLAKrprQk1jebpaYRRHJO7/hNquLeLctUNx3JpaQQEHgRYZgifq35Drm4yof20117WnB0NLtJYCiHRGAyJYjTGpPoVpLxMIrDVxYSFqnGykjXQdvbiF0e2TlVQEMgagbxSuStxMvwlMtcEE98OiEq44fW4uzDIa3G5Pq5L9ByBLtJDucw0ME34YV1g1Y0+to2SYAYAJtdICWNK7CMD1H58R9yHFwt/AaWBmWHOLsPQBMzNMDDQDDeHA8YCMYBz3wELwfcQ46RP0klomkq6SBOGgzBNsTxPKPG7ETpTdJO56rWkwhU0VGQ1szfwwK7+vFaAHACNpLO+u3SqJLq06yPxJ/z0KEoQeZQ4bqiMiN7QNFpvZ4Gp/4feW11019Mu015fHn7XUjiFNrGz/hsdOFwc7fTw0fxkIsWMRDhkPy4by7hPucJmC1S83iItd3VwMGDaV6NlBOQx3atYXpDM5SZv9e7bcPK+cVAeA6HvxuW9P22GwDrUvKRqdmAh/bmnAqpOKR/GAmcg3G9uFCnZyKSTV82YYvmVN/VCusVp+l147AfNCEjgU0iPLZbGf7qADYgm7P0SxJTXSzAc59hrlTuHOTlZaX5wpLQNti9roUCN2QzR8EpamnqF5zhK8QXspeY/YFKwRfTPbwZoFO1KbwzEvVG1Ch2FX7tvhpyQ82QY9O8r6N2woo4DG/wQlKjylwQFcue7r17BOX9xl0BpD8lMBOrTyaPK94vnRWum1xpqd4R90sf5c7l3w0U+z2wDwEBuxeSNi8XFWC",
                Mess = "806879843",
                Timestamp = "1679645656",
                Sign = "OUrizZJJKNrO7WUM+hmu9wlNGlCzK5A3uqxeHXnEZ0mefypWrYu+uBUHqQlUcsBMZMj/aoO0wUZ+maU66BQEPY5BIlkxfqmHdqx0qeK3OMFjYHtyX/zwMbdSLxb0BBZvHrytu2igxEHVgH4FidheakaN7rDplelWFGaWOep5neI=",
                SignType = "rsa"
            };

            // 发起解密验签
            NotifyOrderRequestModel res = client.CallBackExecute(request);

            NotifyOrderData data = res.Data;

            // 根据接收到的数据进行后续业务处理
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetTaxFileResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetTaxFileResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetUserCrossResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetUserCrossResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
                OrderID = "test20230323001",
                RealName = "高斯寒",
                IDCard = "210921199003101415",
                CardNo = "6214830180870857",
                PhoneNo = "",
                Pay = "9.99",
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
                OrderID = "test20230324001",
                RealName = "高斯寒",
                IDCard = "210921199003101415",
                CardNo = "17600957177",
                PhoneNo = "",
                Pay = "1.00",
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
                OrderID = "test20230307003",
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceStatResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceStatResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceAmountResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceAmountResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApplyInvoiceResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApplyInvoiceResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceFileResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceFileResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            SendReminderEmailResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                SendReminderEmailResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
                RealName = "高斯寒",
                IDCard = "210921199003101415",
                CertificateType = 0
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserPresignResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5UserPresignResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
                Token = "55a405a1-4f16-48d0-b573-110331274679",
                Color = "#8171ff",
                URL = "http://www.abcdef.com/api/notify",
                RedirectURL = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserSignResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5UserSignResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetH5UserSignStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetH5UserSignStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
                RealName = "高斯寒",
                IDCard = "210921199003101415",
                CertificateType = 0
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserReleaseResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5UserReleaseResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyOrderFileResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyBillFileV2Response res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDealerRechargeRecordV2Response res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDailyOrderResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDailyBillResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyOrderFileV2Response res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListBalanceDailyStatementResponse res = client.Execute(request);

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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5PreCollectBizlicMsgResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5PreCollectBizlicMsgResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5APIGetStartUrlResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5APIGetStartUrlResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5APIEcoCityAicStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5APIEcoCityAicStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5GetStartUrlResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5GetStartUrlResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5EcoCityAicStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5EcoCityAicStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            IDCardVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                IDCardVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetBankCardInfoResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetBankCardInfoResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardThreeVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardThreeVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardFourVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourAuthVerifyResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardFourAuthVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourAuthConfirmResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardFourAuthConfirmResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
                RealName = "李四",
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
                Ref = "1234567890112"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            UserExemptedInfoResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                UserExemptedInfoResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            UserWhiteCheckResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                UserWhiteCheckResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 获取协议预览 URL
        public static void ApiUseSignContract_Example()
        {
            // 实例化具体 API 对应的 request 类
            ApiUserSignContractRequest request = new ApiUserSignContractRequest();
            // 加载接口参数
            ApiUserSignContractRequestModel model = new ApiUserSignContractRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUserSignContractResponse res = client.Execute(request);
            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApiUserSignContractResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUserSignResponse res = client.Execute(request);
            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApiUserSignResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetApiUserSignStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetApiUserSignStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
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
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApiUserSignReleaseResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApiUserSignReleaseResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

    }
}
