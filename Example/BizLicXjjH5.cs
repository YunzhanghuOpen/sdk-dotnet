using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 云账户新经济（H5）个体工商户注册
    /// </summary>
    public class BizLicXjjH5
    {
        // 获取基础配置信息
        static YzhConfig config = ConfigUtil.GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        
        // 预启动
        public static void H5GetStartUrl_Example()
        { 
            // 实例化具体 API 对应的 request 类
            H5GetStartUrlRequest request = new H5GetStartUrlRequest();
            // 加载接口参数
            H5GetStartUrlRequestModel model = new H5GetStartUrlRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                ClientType = 1,
                NotifyURL = "http://www.abcdef.com/api/notify",
                Color = "#007AFF",
                ReturnURL = "",
                CustomerTitle = 1
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5GetStartUrlResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5GetStartUrlResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询个体工商户状态
        public static void H5EcoCityAicStatus_Example()
        { 
            // 实例化具体 API 对应的 request 类
            H5EcoCityAicStatusRequest request = new H5EcoCityAicStatusRequest();
            // 加载接口参数
            H5EcoCityAicStatusRequestModel model = new H5EcoCityAicStatusRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                DealerUserID = "123456",
                RealName = "张三",
                IDCard = "110101198010211242",
                OpenID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            H5EcoCityAicStatusResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                H5EcoCityAicStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}
