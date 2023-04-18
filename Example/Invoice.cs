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

            // 加载接口参数
            GetInvoiceStatRequestModel model = new GetInvoiceStatRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                Year = 2023,
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetInvoiceStatResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceStatResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询可开具发票额度和发票开具信息
        public static void GetInvoiceAmount()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceAmountRequest request = new GetInvoiceAmountRequest();

            // 加载接口参数
            GetInvoiceAmountRequestModel model = new GetInvoiceAmountRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetInvoiceAmountResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceAmountResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 发票开具申请
        public static void ApplyInvoice()
        {
            // 实例化具体 API 对应的 request 类
            ApplyInvoiceRequest request = new ApplyInvoiceRequest();

            // 加载接口参数
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

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            ApplyInvoiceResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                ApplyInvoiceResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询发票开具申请状态
        public static void GetInvoiceStatus()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceStatusRequest request = new GetInvoiceStatusRequest();

            // 加载接口参数
            GetInvoiceStatusRequestModel model = new GetInvoiceStatusRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = "test12776352",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetInvoiceStatusResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceStatusResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 下载 PDF 版发票
        public static void GetInvoiceFile()
        {
            // 实例化具体 API 对应的 request 类
            GetInvoiceFileRequest request = new GetInvoiceFileRequest();

            // 加载接口参数
            GetInvoiceFileRequestModel model = new GetInvoiceFileRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = "test12776352",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetInvoiceFileResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetInvoiceFileResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 发送发票扫描件压缩包下载链接邮件
        public static void SendReminderEmail()
        {
            // 实例化具体 API 对应的 request 类
            SendReminderEmailRequest request = new SendReminderEmailRequest();

            // 加载接口参数
            SendReminderEmailRequestModel model = new SendReminderEmailRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = "test12776352",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            SendReminderEmailResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                SendReminderEmailResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}
