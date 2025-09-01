using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 回调通知
    /// </summary>
    public class Notify
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
        /// 订单支付状态回调通知
        /// </summary>
        public static void NotifyOrderData()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyOrderRequestModel> request = new YzhCallbackRequest<NotifyOrderRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyOrderRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
                NotifyOrderData data = res.Data;
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 发票开具完成通知
        /// </summary>
        public static void NotifyInvoiceDone()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyInvoiceDoneRequestModel> request = new YzhCallbackRequest<NotifyInvoiceDoneRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyInvoiceDoneRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            } 
        }

        /// <summary>
        /// 个体工商户注册结果回调（云账户新经济 H5）
        /// </summary>
        public static void NotifyH5EcoCityAic()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyH5EcoCityAicRequestModel> request = new YzhCallbackRequest<NotifyH5EcoCityAicRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyH5EcoCityAicRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            } 
        }

        /// <summary>
        /// 个体工商户注册结果回调（云账户新经济 H5+API）
        /// </summary>
        public static void NotifyH5APIEcoCityAic()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyH5APIEcoCityAicRequestModel> request = new YzhCallbackRequest<NotifyH5APIEcoCityAicRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyH5APIEcoCityAicRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            } 
        }

        /// <summary>
        /// 个体工商户注册/注销结果回调（云账户共享大额 H5）
        /// </summary>
        public static void NotifyGxV2H5Aic()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyGxV2H5AicRequestModel> request = new YzhCallbackRequest<NotifyGxV2H5AicRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyGxV2H5AicRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            } 
        }

        /// <summary>
        /// 个体工商户注册/注销结果回调（云账户共享大额 H5+API）
        /// </summary>
        public static void NotifyGxV2H5APIAic()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyGxV2H5APIAicRequestModel> request = new YzhCallbackRequest<NotifyGxV2H5APIAicRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyGxV2H5APIAicRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            } 
        }

        /// <summary>
        /// H5 签约回调
        /// </summary>
        public static void NotifyH5UserSign()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyH5UserSignRequestModel> request = new YzhCallbackRequest<NotifyH5UserSignRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyH5UserSignRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            } 
        }

        /// <summary>
        /// 免验证名单审核结果回调通知
        /// </summary>
        public static void NotifyUserExemptedInfo()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyUserExemptedInfoRequestModel> request = new YzhCallbackRequest<NotifyUserExemptedInfoRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyUserExemptedInfoRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            } 
        }

        /// <summary>
        /// 签约成功状态回调通知
        /// </summary>
        public static void NotifyUploadUserSignStatus()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyUploadUserSignRequestModel> request = new YzhCallbackRequest<NotifyUploadUserSignRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyUploadUserSignRequestModel res = Client.NotifyDecoder(request);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 收集手机号码结果回调通知
        /// </summary>
        public static void NotifyUserCollectPhone()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyUserCollectPhoneRequestModel> request = new YzhCallbackRequest<NotifyUserCollectPhoneRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyUserCollectPhoneRequestModel res = Client.NotifyDecoder(request);
                string json = JsonConvert.SerializeObject(res);
                Console.WriteLine(json);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 劳务模式订单支付状态回调通知
        /// </summary>
        public static void NotifyOrderLxlw()
        {
            // 实例化验签解密对应的 request 类
            YzhCallbackRequest<NotifyOrderLxlwRequestModel> request = new YzhCallbackRequest<NotifyOrderLxlwRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起验签解密
            try
            {
                NotifyOrderLxlwRequestModel res = Client.NotifyDecoder(request);
                NotifyOrderLxlwData data = res.Data;
                string json = JsonConvert.SerializeObject(data);
                Console.WriteLine(json);
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }
    }
}