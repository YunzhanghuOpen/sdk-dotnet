using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// H5 签约
    /// </summary>
    public class H5UserSign
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 预申请签约
        public static void H5UserPresign_Example()
        {
            // 实例化具体 API 对应的 request 类
            H5UserPresignRequest request = new H5UserPresignRequest();

            // 加载接口参数
            H5UserPresignRequestModel model = new H5UserPresignRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "1102321742183272",
                CertificateType = 0,
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            H5UserPresignResponse res = Client.Execute(request);

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

        // 申请签约
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
                RedirectURL = "http://www.abcdef.com/api/redirecturl",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            H5UserSignResponse res = Client.Execute(request);

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
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "1233984756231232",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetH5UserSignStatusResponse res = Client.Execute(request);

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

        // 用户解约
        public static void H5UserRelease_Example()
        {
            // 实例化具体 API 对应的 request 类
            H5UserReleaseRequest request = new H5UserReleaseRequest();

            // 加载接口参数
            H5UserReleaseRequestModel model = new H5UserReleaseRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "1233984756231232",
                CertificateType = 0,
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            H5UserReleaseResponse res = Client.Execute(request);

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
    }
}
