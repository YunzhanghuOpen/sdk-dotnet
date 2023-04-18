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
        public static void NotifyOrderData_Example()
        {
            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyOrderRequestModel> request = new YzhCallbackRequest<NotifyOrderRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起解密验签
            NotifyOrderRequestModel res = Client.CallBackExecute(request);

            Console.WriteLine(res.Data);

            NotifyOrderData data = res.Data;
        }

        // 发票开具完成通知
        public static void NotifyInvoiceDone_Example()
        {
            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyInvoiceDoneRequestModel> request = new YzhCallbackRequest<NotifyInvoiceDoneRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起解密验签
            NotifyInvoiceDoneRequestModel res = Client.CallBackExecute(request);

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
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起解密验签
            NotifyH5EcoCityAicRequestModel res = Client.CallBackExecute(request);

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
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起解密验签
            NotifyH5UserSignRequestModel res = Client.CallBackExecute(request);

            // 根据回调信息处理
            Console.WriteLine("用户姓名：" + res.RealName + "\n证件号：" + res.IDCard);
        }

        // 免验证名单审核结果回调通知
        public static void NotifyUserExemptedInfo_Example()
        {
            // 实例化解密验签对应的 request 类
            YzhCallbackRequest<NotifyUserExemptedInfoRequestModel> request = new YzhCallbackRequest<NotifyUserExemptedInfoRequestModel>()
            {
                Data = "testData",
                Mess = "testMess",
                Timestamp = "testTimestamp",
                Sign = "testSign",
                SignType = "testSignType",
            };

            // 发起解密验签
            NotifyUserExemptedInfoRequestModel res = Client.CallBackExecute(request);

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
    }
}