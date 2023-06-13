using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 发票开具
    /// </summary>
    public class Invoice
    {
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 查询平台企业已开具和待开具发票金额
        public static void GetInvoiceStat()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceStatRequest request = new GetInvoiceStatRequest();

            // 配置请求参数
            GetInvoiceStatRequestModel model = new GetInvoiceStatRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Year = 2023,
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetInvoiceStatResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetInvoiceStatResponseModel data = res.Data;
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

        // 查询可开具发票额度和发票开具信息
        public static void GetInvoiceAmount()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceAmountRequest request = new GetInvoiceAmountRequest();

            // 配置请求参数
            GetInvoiceAmountRequestModel model = new GetInvoiceAmountRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetInvoiceAmountResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetInvoiceAmountResponseModel data = res.Data;
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

        // 发票开具申请
        public static void ApplyInvoice()
        {
            // 实例化具体 API 对应的 request 类
            ApplyInvoiceRequest request = new ApplyInvoiceRequest();

            // 配置请求参数
            ApplyInvoiceRequestModel model = new ApplyInvoiceRequestModel
            {
                InvoiceApplyID = "1231232131",
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Amount = "100000.00",
                InvoiceType = "1",
                BankNameAccount = "交通银行北京东大桥支行 12343456654321",
                GoodsServicesName = "信息技术服务*信息技术服务费",
                Remark = "测试备注内容",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ApplyInvoiceResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    ApplyInvoiceResponseModel data = res.Data;
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

        // 查询发票开具申请状态
        public static void GetInvoiceStatus()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceStatusRequest request = new GetInvoiceStatusRequest();

            // 配置请求参数
            GetInvoiceStatusRequestModel model = new GetInvoiceStatusRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = "test12776352",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetInvoiceStatusResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetInvoiceStatusResponseModel data = res.Data;
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

        // 查询发票信息
        public static void GetInvoiceInformation()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceInformationRequest request = new GetInvoiceInformationRequest();

            // 配置请求参数
            GetInvoiceInformationRequestModel model = new GetInvoiceInformationRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = "test12776352",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetInvoiceInformationResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetInvoiceInformationResponseModel data = res.Data;
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

        // 下载 PDF 版发票
        public static void GetInvoiceFile()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceFileRequest request = new GetInvoiceFileRequest();

            // 配置请求参数
            GetInvoiceFileRequestModel model = new GetInvoiceFileRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = "test12776352",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetInvoiceFileResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetInvoiceFileResponseModel data = res.Data;
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

        // 发送发票扫描件压缩包下载链接邮件
        public static void SendReminderEmail()
        {
            // 实例化具体 API 对应的 request 类
            SendReminderEmailRequest request = new SendReminderEmailRequest();

            // 配置请求参数
            SendReminderEmailRequestModel model = new SendReminderEmailRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = "test12776352",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                SendReminderEmailResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    SendReminderEmailResponseModel data = res.Data;
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
