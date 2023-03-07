using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Aop.Api.Example
{
    public class Invoice
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        

        // 查询平台企业已开具和待开具发票金额
        public static void GetInvoiceStat_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceStatRequest request = new GetInvoiceStatRequest();
            // 加载接口参数
            GetInvoiceStatRequestModel model = new GetInvoiceStatRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Year = 2023
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceStatResponse res = client.Execute(request);

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

        // 查询可开具发票额度和发票开具信息
        public static void GetInvoiceAmount_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceAmountRequest request = new GetInvoiceAmountRequest();
            // 加载接口参数
            GetInvoiceAmountRequestModel model = new GetInvoiceAmountRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceAmountResponse res = client.Execute(request);

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

        // 发票开具申请
        public static void ApplyInvoice_Example()
        { 

            // 实例化具体 API 对应的 request 类
            ApplyInvoiceRequest request = new ApplyInvoiceRequest();
            // 加载接口参数
            ApplyInvoiceRequestModel model = new ApplyInvoiceRequestModel
            {
                InvoiceApplyID = "1231232131",
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                Amount = "100000.00",
                InvoiceType = "1",
                BankNameAccount = "交通银行北京东大桥支行 12343456654321",
                GoodsServicesName = "信息技术服务*信息技术服务费",
                Remark = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ApplyInvoiceResponse res = client.Execute(request);

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

        // 查询发票开具申请状态
        public static void GetInvoiceStatus_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceStatusRequest request = new GetInvoiceStatusRequest();
            // 加载接口参数
            GetInvoiceStatusRequestModel model = new GetInvoiceStatusRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceStatusResponse res = client.Execute(request);

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

        // 下载 PDF 版发票
        public static void GetInvoiceFile_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetInvoiceFileRequest request = new GetInvoiceFileRequest();
            // 加载接口参数
            GetInvoiceFileRequestModel model = new GetInvoiceFileRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetInvoiceFileResponse res = client.Execute(request);

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

        // 发送发票扫描件压缩包下载链接邮件
        public static void SendReminderEmail_Example()
        { 

            // 实例化具体 API 对应的 request 类
            SendReminderEmailRequest request = new SendReminderEmailRequest();
            // 加载接口参数
            SendReminderEmailRequestModel model = new SendReminderEmailRequestModel
            {
                InvoiceApplyID = "1231232131",
                ApplicationID = ""
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            SendReminderEmailResponse res = client.Execute(request);

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
            // 设置 App Key
            config.AppKey = "";
            // 设置平台企业私钥
            config.PrivateKey = "";
            // 设置云账户公钥
            config.YzhPublicKey = "";
            // 设置 3DES Key
            config.Des3Key = "";
            // 设置签名方式，rsa 或 sha256
            config.SignType = "";

            return config;
        }
    }
}
