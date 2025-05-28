using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 用户信息验证
    /// </summary>
    public class Authentication
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
        /// 银行卡四要素鉴权请求（下发短信验证码）
        /// </summary>
        public static void BankCardFourAuthVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourAuthVerifyRequest request = new BankCardFourAuthVerifyRequest();

            // 配置请求参数
            BankCardFourAuthVerifyRequestModel model = new BankCardFourAuthVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "11010519491231002X",
                CardNo = "6228888888888888888",
                Mobile = "188****8888",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardFourAuthVerifyResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    BankCardFourAuthVerifyResponseModel data = res.Data;
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
        /// 银行卡四要素确认请求（上传短信验证码）
        /// </summary>
        public static void BankCardFourAuthConfirm()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourAuthConfirmRequest request = new BankCardFourAuthConfirmRequest();

            // 配置请求参数
            BankCardFourAuthConfirmRequestModel model = new BankCardFourAuthConfirmRequestModel
            {
                RealName = "张三",
                IDCard = "11010519491231002X",
                CardNo = "6228888888888888888",
                Mobile = "188****8888",
                Captcha = "123456",
                Ref = "1234567890",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardFourAuthConfirmResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    BankCardFourAuthConfirmResponseModel data = res.Data;
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
        /// 银行卡四要素验证
        /// </summary>
        public static void BankCardFourVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourVerifyRequest request = new BankCardFourVerifyRequest();

            // 配置请求参数
            BankCardFourVerifyRequestModel model = new BankCardFourVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "11010519491231002X",
                CardNo = "6228888888888888888",
                Mobile = "188****8888",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardFourVerifyResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    BankCardFourVerifyResponseModel data = res.Data;
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
        /// 银行卡三要素验证
        /// </summary>
        public static void BankCardThreeVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardThreeVerifyRequest request = new BankCardThreeVerifyRequest();

            // 配置请求参数
            BankCardThreeVerifyRequestModel model = new BankCardThreeVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "11010519491231002X",
                CardNo = "6228888888888888888",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardThreeVerifyResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    BankCardThreeVerifyResponseModel data = res.Data;
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
        /// 身份证实名验证
        /// </summary>
        public static void IDCardVerify()
        {
            // 实例化具体 API 对应的 request 类
            IDCardVerifyRequest request = new IDCardVerifyRequest();

            // 配置请求参数
            IDCardVerifyRequestModel model = new IDCardVerifyRequestModel
            {
                IDCard = "110101198001221211",
                RealName = "张三",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                IDCardVerifyResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    IDCardVerifyResponseModel data = res.Data;
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
        /// 上传非居民身份证验证名单信息
        /// </summary>
        public static void UserExemptedInfo()
        {
            // 实例化具体 API 对应的 request 类
            UserExemptedInfoRequest request = new UserExemptedInfoRequest();

            // 配置请求参数
            UserExemptedInfoRequestModel model = new UserExemptedInfoRequestModel
            {
                RealName = "张三",
                IDCard = "EA3456789",
                CardType = "passport",
                CommentApply = "申请免验证名单",
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                UserImages = new string[] { "...." },
                ImageURLs = new string[] { "https://www.example.com/image01.png" },
                Country = "NOR",
                Birthday = "20010809",
                Gender = "男",
                NotifyURL = "https://www.example.com",
                Ref = "1234567890",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                UserExemptedInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    UserExemptedInfoResponseModel data = res.Data;
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
        /// 查看用户是否在非居民身份证验证名单中
        /// </summary>
        public static void UserWhiteCheck()
        {
            // 实例化具体 API 对应的 request 类
            UserWhiteCheckRequest request = new UserWhiteCheckRequest();

            // 配置请求参数
            UserWhiteCheckRequestModel model = new UserWhiteCheckRequestModel
            {
                RealName = "张三",
                IDCard = "EA3456789",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                UserWhiteCheckResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    UserWhiteCheckResponseModel data = res.Data;
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
        /// 银行卡信息查询
        /// </summary>
        public static void GetBankCardInfo()
        {
            // 实例化具体 API 对应的 request 类
            GetBankCardInfoRequest request = new GetBankCardInfoRequest();

            // 配置请求参数
            GetBankCardInfoRequestModel model = new GetBankCardInfoRequestModel
            {
                CardNo = "6228888888888888888",
                BankName = "招商银行",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetBankCardInfoResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetBankCardInfoResponseModel data = res.Data;
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
