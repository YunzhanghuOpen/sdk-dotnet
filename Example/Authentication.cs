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
        // 获取基础配置信息
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        // 客户端实现
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        // 银行卡四要素鉴权请求（下发短信验证码）
        public static void BankCardFourAuthVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourAuthVerifyRequest request = new BankCardFourAuthVerifyRequest();

            // 配置请求参数
            BankCardFourAuthVerifyRequestModel model = new BankCardFourAuthVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardFourAuthVerifyResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    BankCardFourAuthVerifyResponseModel data = res.Data;
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

        // 银行卡四要素确认请求（上传短信验证码）
        public static void BankCardFourAuthConfirm()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourAuthConfirmRequest request = new BankCardFourAuthConfirmRequest();

            // 配置请求参数
            BankCardFourAuthConfirmRequestModel model = new BankCardFourAuthConfirmRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888",
                Captcha = "12345",
                Ref = "1234567890",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardFourAuthConfirmResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    BankCardFourAuthConfirmResponseModel data = res.Data;
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

        // 银行卡四要素验证
        public static void BankCardFourVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourVerifyRequest request = new BankCardFourVerifyRequest();

            // 配置请求参数
            BankCardFourVerifyRequestModel model = new BankCardFourVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardFourVerifyResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    BankCardFourVerifyResponseModel data = res.Data;
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

        // 银行卡三要素验证
        public static void BankCardThreeVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardThreeVerifyRequest request = new BankCardThreeVerifyRequest();

            // 配置请求参数
            BankCardThreeVerifyRequestModel model = new BankCardThreeVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                BankCardThreeVerifyResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    BankCardThreeVerifyResponseModel data = res.Data;
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

        // 身份证实名验证
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

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                IDCardVerifyResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    IDCardVerifyResponseModel data = res.Data;
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

        // 上传免验证用户名单信息
        public static void UserExemptedInfo()
        {
            // 实例化具体 API 对应的 request 类
            UserExemptedInfoRequest request = new UserExemptedInfoRequest();

            // 配置请求参数
            UserExemptedInfoRequestModel model = new UserExemptedInfoRequestModel
            {
                RealName = "张三",
                IDCard = "M101198001201232",
                CardType = "passport",
                CommentApply = "申请免验证名单",
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                UserImages = new string[] { "igngudaere", "dfafdaea" },
                Country = "NOR",
                Birthday = "20010809",
                Gender = "男",
                NotifyURL = "http://www.abcdef.com/api/notify",
                Ref = "1234567890",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                UserExemptedInfoResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    UserExemptedInfoResponseModel data = res.Data;
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

        // 查看免验证用户名单是否存在
        public static void UserWhiteCheck()
        {
            // 实例化具体 API 对应的 request 类
            UserWhiteCheckRequest request = new UserWhiteCheckRequest();

            // 配置请求参数
            UserWhiteCheckRequestModel model = new UserWhiteCheckRequestModel
            {
                RealName = "张三",
                IDCard = "M101198001201232",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                UserWhiteCheckResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    UserWhiteCheckResponseModel data = res.Data;
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

        // 银行卡信息查询
        public static void GetBankCardInfo()
        {
            // 实例化具体 API 对应的 request 类
            GetBankCardInfoRequest request = new GetBankCardInfoRequest();

            // 配置请求参数
            GetBankCardInfoRequestModel model = new GetBankCardInfoRequestModel
            {
                CardNo = "1234568987645212321",
                BankName = "招商银行",
            };
            request.SetBizModel(model);

            // request-id：请求ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于使用 request-id 追踪问题
            // 如未自定义 request-id，将使用 SDK 中的 Guid.NewGuid() 方法自动生成。注意：Guid.NewGuid() 方法生成的 request-id 不能保证全局唯一，可能会出现 ID 重复，推荐自定义 request-id，实现全局唯一 ID
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetBankCardInfoResponse res = Client.Execute(request);
                if (res.IsSuccess)
                {
                    // 处理成功
                    GetBankCardInfoResponseModel data = res.Data;
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
