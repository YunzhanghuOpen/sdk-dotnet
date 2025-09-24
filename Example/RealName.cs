using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 用户实名认证信息收集
    /// </summary>
    public class RealName
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
        /// 用户实名认证信息收集-人脸认证方式
        /// </summary>
        public static void CollectRealNameInfoFace()
        {
            // 实例化具体 API 对应的 request 类
            CollectRealNameInfoRequest request = new CollectRealNameInfoRequest();

            // 配置请求参数
            CollectRealNameInfoRequestModel model = new CollectRealNameInfoRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "11010519491231002X",
                RealnameResult = 1,
                RealnameTime = "2025-09-09 19:19:19",
                RealnameType = 1,
                RealnameTraceID = "1413536187796566016",
                RealnamePlatform = "xxxxxxx公司",
                FaceImageCollectType = 1,
                FaceImage = "https://www.example.com/file_name.png",
                FaceVerifyScore = "89.12",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CollectRealNameInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CollectRealNameInfoResponseModel data = res.Data;
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
        /// 用户实名认证信息收集-银行卡四要素认证方式
        /// </summary>
        public static void CollectRealNameInfoBank()
        {
            // 实例化具体 API 对应的 request 类
            CollectRealNameInfoRequest request = new CollectRealNameInfoRequest();

            // 配置请求参数
            CollectRealNameInfoRequestModel model = new CollectRealNameInfoRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "11010519491231002X",
                RealnameResult = 1,
                RealnameTime = "2025-09-09 19:19:19",
                RealnameType = 2,
                RealnameTraceID = "1413536187796566016",
                RealnamePlatform = "xxxxxxx公司",
                BankNo = "6127000xxxxxxx16",
                BankPhone = "188xxx8888",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CollectRealNameInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CollectRealNameInfoResponseModel data = res.Data;
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
        /// 用户实名认证信息收集-人工审核
        /// </summary>
        public static void CollectRealNameInfoReviewer()
        {
            // 实例化具体 API 对应的 request 类
            CollectRealNameInfoRequest request = new CollectRealNameInfoRequest();

            // 配置请求参数
            CollectRealNameInfoRequestModel model = new CollectRealNameInfoRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "11010519491231002X",
                RealnameResult = 1,
                RealnameTime = "2025-09-09 19:19:19",
                RealnameType = 3,
                RealnameTraceID = "1413536187796566016",
                RealnamePlatform = "xxxxxxx公司",
                FaceImageCollectType = 1,
                FaceImage = "https://www.example.com/file_name.png",
                FaceVerifyScore = "89.12",
                BankNo = "6127000xxxxxxx16",
                BankPhone = "188xxx8888",
                Reviewer = "908xxx8888",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                CollectRealNameInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CollectRealNameInfoResponseModel data = res.Data;
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
        /// 用户实名认证信息查询
        /// </summary>
        public static void QueryRealNameInfo()
        {
            // 实例化具体 API 对应的 request 类
            QueryRealNameInfoRequest request = new QueryRealNameInfoRequest();

            // 配置请求参数
            QueryRealNameInfoRequestModel model = new QueryRealNameInfoRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
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
                QueryRealNameInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    QueryRealNameInfoResponseModel data = res.Data;
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

