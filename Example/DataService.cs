using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class DataService
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

        //查询日订单文件
        public void GetOrderDownloadsUrl_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetDailyOrderFileRequest();
            //加载接口参数
            var model = new GetDailyOrderFileRequestModel
            {
                OrderDate = "2022-03-23"
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

        //查询日流水文件
        public void GetDailyBillFileV2_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetDailyBillFileV2Request();
            //加载接口参数
            var model = new GetDailyBillFileV2RequestModel
            {
                BillDate = "2022-03-23"
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

        //查询平台企业预付业务服务费记录
        public void ListDealerRechargeRecordV2_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new ListDealerRechargeRecordV2Request();
            //加载接口参数
            var model = new ListDealerRechargeRecordV2RequestModel
            {
                BeginAt = "2022-03-23",
                EndAt = "2022-03-30"
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

        //查询日订单数据
        public void ListDailyOrder_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new ListDailyOrderRequest();
            //加载接口参数
            var model = new ListDailyOrderRequestModel
            {
                OrderDate = "2022-03-23",
                Offset = 0,
                Length = 100,
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

        //查询日流水数据
        public void ListDailyBill_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new ListDailyBillRequest();
            //加载接口参数
            var model = new ListDailyBillRequestModel
            {
                BillDate = "2022-03-23",
                Offset = 0,
                Length = 100,
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

        //查询日订单文件（支付和退款订单）
        public void GetDailyOrderFileV2_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetDailyOrderFileV2Request();
            //加载接口参数
            var model = new GetDailyOrderFileV2RequestModel
            {
                OrderDate = "2022-03-23"
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

        //查询余额日账单数据
        public void ListBalanceDailyStatement_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new ListBalanceDailyStatementRequest();
            //加载接口参数
            var model = new ListBalanceDailyStatementRequestModel
            {
                StatementDate = "2022-03-23"
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
