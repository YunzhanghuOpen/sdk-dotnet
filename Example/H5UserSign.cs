using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Aop.Api.Example
{
    public class H5UserSign
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        // 设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒
        // client.SetTimeout(30000); 

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
                RealName = "张三",
                IDCard = "1102321742183272",
                CertificateType = 0
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserPresignResponse res = client.Execute(request);

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

        // H5 申请签约
        public static void H5UserSign_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5UserSignRequest request = new H5UserSignRequest();
            // 加载接口参数
            H5UserSignRequestModel model = new H5UserSignRequestModel
            {
                Token = "1231231jdfalrejia",
                Color = "#8171ff",
                URL = "http://www.abcdef.com/api/notify",
                RedirectURL = ""
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserSignResponse res = client.Execute(request);

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
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetH5UserSignStatusResponse res = client.Execute(request);

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

        // H5 对接测试解约接口
        public static void H5UserRelease_Example()
        { 

            // 实例化具体 API 对应的 request 类
            H5UserReleaseRequest request = new H5UserReleaseRequest();
            // 加载接口参数
            H5UserReleaseRequestModel model = new H5UserReleaseRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                RealName = "张三",
                IDCard = "1233984756231232",
                CertificateType = 0
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5UserReleaseResponse res = client.Execute(request);

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
