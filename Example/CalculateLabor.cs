using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 连续劳务税费试算
    /// </summary>
    public class CalculateLabor
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
        /// 连续劳务税费试算（计算器）
        /// </summary>
        public static void LaborCaculator()
        {
            // 实例化具体 API 对应的 request 类
            LaborCaculatorRequest request = new LaborCaculatorRequest();

            // 配置请求参数
            LaborCaculatorRequestModel model = new LaborCaculatorRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                MonthSettlementList = new MonthSettlement[]
                {
                    new MonthSettlement
                    {
                        Month = 1,
                        MonthPreTaxAmount = "10.00",
                    }, new MonthSettlement
                    {
                        Month = 2,
                        MonthPreTaxAmount = "10.00",
                    }
                },
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                LaborCaculatorResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    LaborCaculatorResponseModel data = res.Data;
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
        /// 订单税费试算
        /// </summary>
        public static void CalcTax()
        {
            // 实例化具体 API 对应的 request 类
            CalcTaxRequest request = new CalcTaxRequest();

            // 配置请求参数
            CalcTaxRequestModel model = new CalcTaxRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "11010519491231002X", 
                Pay = "99",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CalcTaxResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CalcTaxResponseModel data = res.Data;
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

