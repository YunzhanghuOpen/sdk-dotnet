﻿using System;
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

        // 身份证实名验证
        public static void IDCardVerify()
        {
            // 实例化具体 API 对应的 request 类
            IDCardVerifyRequest request = new IDCardVerifyRequest();

            // 加载接口参数
            IDCardVerifyRequestModel model = new IDCardVerifyRequestModel
            {
                IDCard = "110101198001221211",
                RealName = "张三",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            IDCardVerifyResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                IDCardVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 银行卡信息查询
        public static void GetBankCardInfo()
        {
            // 实例化具体 API 对应的 request 类
            GetBankCardInfoRequest request = new GetBankCardInfoRequest();

            // 加载接口参数
            GetBankCardInfoRequestModel model = new GetBankCardInfoRequestModel
            {
                CardNo = "1234568987645212321",
                BankName = "招商银行",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            GetBankCardInfoResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                GetBankCardInfoResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 银行卡三要素验证
        public static void BankCardThreeVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardThreeVerifyRequest request = new BankCardThreeVerifyRequest();

            // 加载接口参数
            BankCardThreeVerifyRequestModel model = new BankCardThreeVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            BankCardThreeVerifyResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardThreeVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 银行卡四要素验证
        public static void BankCardFourVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourVerifyRequest request = new BankCardFourVerifyRequest();

            // 加载接口参数
            BankCardFourVerifyRequestModel model = new BankCardFourVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            BankCardFourVerifyResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardFourVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 银行卡四要素鉴权请求（下发短信验证码）
        public static void BankCardFourAuthVerify()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourAuthVerifyRequest request = new BankCardFourAuthVerifyRequest();

            // 加载接口参数
            BankCardFourAuthVerifyRequestModel model = new BankCardFourAuthVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            BankCardFourAuthVerifyResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardFourAuthVerifyResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 银行卡四要素确认请求（上传短信验证码）
        public static void BankCardFourAuthConfirm()
        {
            // 实例化具体 API 对应的 request 类
            BankCardFourAuthConfirmRequest request = new BankCardFourAuthConfirmRequest();

            // 加载接口参数
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

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            BankCardFourAuthConfirmResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                BankCardFourAuthConfirmResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 上传免验证用户名单信息
        public static void UserExemptedInfo()
        {
            // 实例化具体 API 对应的 request 类
            UserExemptedInfoRequest request = new UserExemptedInfoRequest();

            // 加载接口参数
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

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            UserExemptedInfoResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                UserExemptedInfoResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }

        // 查看免验证用户名单是否存在
        public static void UserWhiteCheck()
        {
            // 实例化具体 API 对应的 request 类
            UserWhiteCheckRequest request = new UserWhiteCheckRequest();

            // 加载接口参数
            UserWhiteCheckRequestModel model = new UserWhiteCheckRequestModel
            {
                RealName = "张三",
                IDCard = "M101198001201232",
            };
            request.SetBizModel(model);

            // 设置 request-id，如遇异常请求，为方便定位异常原因，强烈建议平台企业自定义并记录在日志中，如未自定义则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            UserWhiteCheckResponse res = Client.Execute(request);

            Console.WriteLine(res.Body);
            if (res.IsSuccess)
            {
                UserWhiteCheckResponseModel data = res.Data;
            }
            else
            {
                // 处理异常情况
                Console.WriteLine("响应码：" + res.Code + "\n响应信息：" + res.Message);
            }
        }
    }
}
