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
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 订单支付状态回调通知
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

        // 发票开具完成通知
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

        // 个体工商户注册结果回调（云账户新经济 H5）
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

        // 个体工商户注册结果回调（云账户新经济 H5+API）
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

        // H5 签约回调
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

        // 免验证名单审核结果回调通知
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
    }
}