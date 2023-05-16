using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 个人所得税扣缴明细表
    /// </summary>
    public class Tax
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 下载个人所得税扣缴明细表
        public static void GetTaxFile()
        {
            // 实例化具体 API 对应的 request 类
            GetTaxFileRequest request = new GetTaxFileRequest();

            // 加载接口参数
            GetTaxFileRequestModel model = new GetTaxFileRequestModel
            {
                DealerID = Config.DealerID,
                EntID = "accumulus_tj",
                YearMonth = "2023-01",
            };
            request.SetBizModel(model);

            // 如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义 request-id 并记录在日志中，便于使用 request-id 追踪问题
            // 注意：自定义 request-id 时，需保证每次请求的 request-id 具有唯一性
            // 如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetTaxFileResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetTaxFileResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询纳税人是否为跨集团用户
        public static void GetUserCross()
        {
            // 实例化具体 API 对应的 request 类
            GetUserCrossRequest request = new GetUserCrossRequest();

            // 加载接口参数
            GetUserCrossRequestModel model = new GetUserCrossRequestModel
            {
                DealerID = Config.DealerID,
                EntID = "accumulus_tj",
                Year = "2023",
                IDCard = "110101198010021201",
            };
            request.SetBizModel(model);

            // 如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义 request-id 并记录在日志中，便于使用 request-id 追踪问题
            // 注意：自定义 request-id 时，需保证每次请求的 request-id 具有唯一性
            // 如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetUserCrossResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetUserCrossResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}
