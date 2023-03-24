using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.config;
using System.Collections.Generic;

namespace Aop.Api.Example
{
    /// <summary>
    /// 对账文件获取
    /// </summary>
    public class DataService
    {
        // 获取基础配置信息
        static YzhConfig config = ConfigUtil.GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        
        // 查询日订单文件
        public static void GetOrderDownloadsUrl_Example()
        { 
            // 实例化具体 API 对应的 request 类
            GetDailyOrderFileRequest request = new GetDailyOrderFileRequest();
            // 加载接口参数
            GetDailyOrderFileRequestModel model = new GetDailyOrderFileRequestModel
            {
                OrderDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyOrderFileResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 对数据进行处理
                GetDailyOrderFileResponseModel data = res.Data;
            }
            else
            {
                // 处理返回异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日流水文件
        public static void GetDailyBillFileV2_Example()
        {
            // 实例化具体 API 对应的 request 类
            GetDailyBillFileV2Request request = new GetDailyBillFileV2Request();
            // 加载接口参数
            GetDailyBillFileV2RequestModel model = new GetDailyBillFileV2RequestModel
            {
                BillDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyBillFileV2Response res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 对数据进行处理
                GetDailyBillFileV2ResponseModel data = res.Data;
            }
            else
            {
                // 处理返回异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询平台企业预付业务服务费记录
        public static void ListDealerRechargeRecordV2_Example()
        {
            // 实例化具体 API 对应的 request 类
            ListDealerRechargeRecordV2Request request = new ListDealerRechargeRecordV2Request();
            // 加载接口参数
            ListDealerRechargeRecordV2RequestModel model = new ListDealerRechargeRecordV2RequestModel
            {
                BeginAt = "2022-03-23",
                EndAt = "2022-03-30"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDealerRechargeRecordV2Response res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 对数据进行处理
                List<RechargeRecordInfo> data = res.Data;
            }
            else
            {
                // 处理返回异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日订单数据
        public static void ListDailyOrder_Example()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyOrderRequest request = new ListDailyOrderRequest();
            // 加载接口参数
            ListDailyOrderRequestModel model = new ListDailyOrderRequestModel
            {
                OrderDate = "2022-03-23",
                Offset = 0,
                Length = 100,
                Channel = "银行卡",
                DataType = "encryption"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDailyOrderResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 对数据进行处理
                ListDailyOrderResponseModel data = res.Data;
            }
            else
            {
                // 处理返回异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日流水数据
        public static void ListDailyBill_Example()
        {
            // 实例化具体 API 对应的 request 类
            ListDailyBillRequest request = new ListDailyBillRequest();
            // 加载接口参数
            ListDailyBillRequestModel model = new ListDailyBillRequestModel
            {
                BillDate = "2022-03-23",
                Offset = 0,
                Length = 100,
                DataType = "encryption"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListDailyBillResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 对数据进行处理
                ListDailyBillResponseModel data = res.Data;
            }
            else
            {
                // 处理返回异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询日订单文件（支付和退款订单）
        public static void GetDailyOrderFileV2_Example()
        {
            // 实例化具体 API 对应的 request 类
            GetDailyOrderFileV2Request request = new GetDailyOrderFileV2Request();
            // 加载接口参数
            GetDailyOrderFileV2RequestModel model = new GetDailyOrderFileV2RequestModel
            {
                OrderDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetDailyOrderFileV2Response res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 对数据进行处理
                GetDailyOrderFileV2ResponseModel data = res.Data;
            }
            else
            {
                // 处理返回异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查询余额日账单数据
        public static void ListBalanceDailyStatement_Example()
        {
            // 实例化具体 API 对应的 request 类
            ListBalanceDailyStatementRequest request = new ListBalanceDailyStatementRequest();
            // 加载接口参数
            ListBalanceDailyStatementRequestModel model = new ListBalanceDailyStatementRequestModel
            {
                StatementDate = "2022-03-23"
            };
            request.SetBizModel(model);
            // 设置 request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            ListBalanceDailyStatementResponse res = client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                // 对数据进行处理
                ListBalanceDailyStatementResponseModel data = res.Data;
            }
            else
            {
                // 处理返回异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}
