using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class BizLicXjjH5
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

        //预启动
        public void H5GetStartUrl_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new H5GetStartUrlRequest();
            //加载接口参数
            var model = new H5GetStartUrlRequestModel
            {
                DealerID=config.DealerID,
                BrokerID=config.BrokerID,
                DealerUserID="123456",
                ClientType=1,
                NotifyURL= "http://www.abcdef.com/api/notify",
                Color= "#007AFF",
                ReturnURL="",
                CustomerTitle=1
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

        //查询个体工商户状态
        public void H5EcoCityAicStatus_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new H5EcoCityAicStatusRequest();
            //加载接口参数
            var model = new H5EcoCityAicStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                RealName="张三",
                IDCard="110101198010211242",
                OpenID=""
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
