using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 个人所得税申报明细表
    /// </summary>
    public class Tax
    {
        /// <summary>
        /// 获取基础配置信息
        /// </summary>
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        /// <summary>
        /// 客户端实现
        /// </summary>
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        /// <summary>
        /// 下载个人所得税申报明细表
        /// </summary>
        public static void GetTaxFile()
        {
            // 实例化具体 API 对应的 request 类
            GetTaxFileRequest request = new GetTaxFileRequest();

            // 配置请求参数
            GetTaxFileRequestModel model = new GetTaxFileRequestModel
            {
                DealerID = Config.DealerID,
                EntID = "accumulus_tj",
                YearMonth = "2023-01",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetTaxFileResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetTaxFileResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 查询纳税人是否为跨集团用户
        /// </summary>
        public static void GetUserCross()
        {
            // 实例化具体 API 对应的 request 类
            GetUserCrossRequest request = new GetUserCrossRequest();

            // 配置请求参数
            GetUserCrossRequestModel model = new GetUserCrossRequestModel
            {
                DealerID = Config.DealerID,
                EntID = "accumulus_tj",
                Year = "2023",
                IDCard = "11010519491231002X",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetUserCrossResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetUserCrossResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
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
