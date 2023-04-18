using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 云账户新经济（H5+API）个体工商户注册
    /// </summary>
    public class BizLicXjjH5Api
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 工商实名信息录入
        public static void H5PreCollectBizlicMsg_Example()
        {
            // 实例化具体 API 对应的 request 类
            H5PreCollectBizlicMsgRequest request = new H5PreCollectBizlicMsgRequest();

            // 加载接口参数
            H5PreCollectBizlicMsgRequestModel model = new H5PreCollectBizlicMsgRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                PhoneNo = "18888888888",
                IDCard = "110101198010211423",
                RealName = "张三",
                IDCardAddress = "北京市朝阳区",
                IDCardAgency = "北京市朝阳区派出所",
                IDCardNation = "20",
                IDCardValidityStart = "2020-10-01",
                IDCardValidityEnd = "2040-10-01",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            H5PreCollectBizlicMsgResponse res = Client.Execute(request);

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
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                ClientType = 2,
                NotifyURL = "http://www.abcdef.com/api/notify",
                Color = "#007AFF",
                ReturnURL = "http://www.abcdef.com/api/returnurl",
                CustomerTitle = 1,
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            H5APIGetStartUrlResponse res = Client.Execute(request);

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
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                RealName = "张三",
                IDCard = "110101198010211242",
                OpenID = "AIjdiahekrSDHOjkdi",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            H5APIEcoCityAicStatusResponse res = Client.Execute(request);

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
    }
}
