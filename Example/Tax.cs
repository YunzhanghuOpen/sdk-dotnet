using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class Tax
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

        //下载个人所得税扣缴明细表
        public void GetTaxFile_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetTaxFileRequest();
            //加载接口参数
            var model = new GetTaxFileRequestModel
            {
                DealerID = config.DealerID,
                EntID = "accumulus_tj",
                YearMonth = "2023-01"
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

        //查询纳税人是否为跨集团用户
        public void GetUserCross_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetUserCrossRequest();
            //加载接口参数
            var model = new GetUserCrossRequestModel
            {
                DealerID = config.DealerID,
                EntID = "accumulus_tj",
                Year = "2023",
                IDCard = "110101198010021201"
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
