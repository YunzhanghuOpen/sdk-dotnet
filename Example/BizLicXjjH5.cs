using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 个体工商户注册（云账户新经济 H5）
    /// </summary>
    public class BizLicXjjH5
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 预启动
        public static void H5GetStartUrl()
        {
            // 实例化具体 API 对应的 request 类
            H5GetStartUrlRequest request = new H5GetStartUrlRequest();

            // 配置请求参数
            H5GetStartUrlRequestModel model = new H5GetStartUrlRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                ClientType = 1,
                NotifyURL = "http://www.abcdef.com/api/notify",
                Color = "#007AFF",
                ReturnURL = "http://www.abcdef.com/api/returnurl",
                CustomerTitle = 1,
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5GetStartUrlResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    H5GetStartUrlResponseModel data = res.Data;
                    Console.WriteLine(data);
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("响应码：" + res.Code + "\n响应码描述：" + res.Message);
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        // 查询个体工商户状态
        public static void H5EcoCityAicStatus()
        {
            // 实例化具体 API 对应的 request 类
            H5EcoCityAicStatusRequest request = new H5EcoCityAicStatusRequest();

            // 配置请求参数
            H5EcoCityAicStatusRequestModel model = new H5EcoCityAicStatusRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                DealerUserID = "123456",
                RealName = "张三",
                IDCard = "110101198010211242",
                OpenID = "",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5EcoCityAicStatusResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    H5EcoCityAicStatusResponseModel data = res.Data;
                    Console.WriteLine(data);
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("响应码：" + res.Code + "\n响应码描述：" + res.Message);
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }
    }
}
