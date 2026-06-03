using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 人脸识别实名核验
    /// </summary>
    public class FaceAuth
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
        /// 申请人脸识别实名核验
        /// </summary>
        public static void ApplyFaceAuth()
        {
            // 实例化具体 API 对应的 request 类
            ApplyFaceAuthRequest request = new ApplyFaceAuthRequest();

            // 配置请求参数
            ApplyFaceAuthRequestModel model = new ApplyFaceAuthRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                VerificationID = "verification_id_123456",
                RealName = "张三",
                IDCard = "11010519491231002X",
                CallbackURL = "https://www.example.com/callback",
                RedirectURL = "https://www.example.com/redirect",
                Color = "#8171ff",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                ApplyFaceAuthResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    ApplyFaceAuthResponseModel data = res.Data;
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
        /// 查询人脸识别实名核验结果
        /// </summary>
        public static void GetFaceAuthResult()
        {
            // 实例化具体 API 对应的 request 类
            GetFaceAuthResultRequest request = new GetFaceAuthResultRequest();

            // 配置请求参数
            GetFaceAuthResultRequestModel model = new GetFaceAuthResultRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RecordID = "record_id_123456",
                VerificationID = "verification_id_123456",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetFaceAuthResultResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetFaceAuthResultResponseModel data = res.Data;
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
