using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class BizLicXjjH5Api
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        // 设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒
        // client.SetTimeout(30000); 

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
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
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
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
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
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
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

        // 获取基础配置信息
        public static YzhConfig GetConfig()
        {
            YzhConfig config = new YzhConfig();
            // 设置接口基础地址
            config.ServerUrl = "";
            // 设置平台企业 ID
            config.DealerID = "";
            // 设置综合服务主体 ID
            config.BrokerID = "";
            //设置 App Key
            config.AppKey = "";
            //设置平台企业私钥
            config.PrivateKey = "";
            //设置云账户公钥
            config.YzhPublicKey = "";
            //设置 3DES Key
            config.Des3Key = "";
            //设置签名方式，rsa 或 sha256
            config.SignType = "";

            return config;
        }
    }
}
