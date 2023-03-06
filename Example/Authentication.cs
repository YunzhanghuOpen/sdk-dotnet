﻿using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class Authentication
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        // 设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒
        // client.SetTimeout(30000); 

        // 身份实名验证
        public static void IDCardVerify_Example()
        { 

            // 实例化具体 API 对应的 request 类
            IDCardVerifyRequest request = new IDCardVerifyRequest();
            // 加载接口参数
            IDCardVerifyRequestModel model = new IDCardVerifyRequestModel
            {
                IDCard = "110101198001221211",
                RealName = "张三"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            IDCardVerifyResponse res = client.Execute(request);

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

        // 银行卡信息查询
        public static void GetBankCardInfo_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetBankCardInfoRequest request = new GetBankCardInfoRequest();
            // 加载接口参数
            GetBankCardInfoRequestModel model = new GetBankCardInfoRequestModel
            {
                CardNo = "1234568987645212321",
                BankName = "招商银行"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetBankCardInfoResponse res = client.Execute(request);

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

        // 银行卡三要素验证
        public static void BankCardThreeVerify_Example()
        { 

            // 实例化具体 API 对应的 request 类
            BankCardThreeVerifyRequest request = new BankCardThreeVerifyRequest();
            // 加载接口参数
            BankCardThreeVerifyRequestModel model = new BankCardThreeVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardThreeVerifyResponse res = client.Execute(request);

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

        // 银行卡四要素验证
        public static void BankCardFourVerify_Example()
        { 

            // 实例化具体 API 对应的 request 类
            BankCardFourVerifyRequest request = new BankCardFourVerifyRequest();
            // 加载接口参数
            BankCardFourVerifyRequestModel model = new BankCardFourVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourVerifyResponse res = client.Execute(request);

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

        // 银行卡四要素鉴权请求（下发短信验证码）
        public static void BankCardFourAuthVerify_Example()
        { 

            // 实例化具体 API 对应的 request 类
            BankCardFourAuthVerifyRequest request = new BankCardFourAuthVerifyRequest();
            // 加载接口参数
            BankCardFourAuthVerifyRequestModel model = new BankCardFourAuthVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourAuthVerifyResponse res = client.Execute(request);

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

        // 银行卡四要素确认请求（上传短信验证码）
        public static void BankCardFourAuthConfirm_Example()
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
                Ref = "1234567890"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            BankCardFourAuthConfirmResponse res = client.Execute(request);

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

        // 上传免验证用户名单信息
        public static void UserExemptedInfo_Example()
        { 

            // 实例化具体 API 对应的 request 类
            UserExemptedInfoRequest request = new UserExemptedInfoRequest();
            // 加载接口参数
            UserExemptedInfoRequestModel model = new UserExemptedInfoRequestModel
            {
                // 姓名
                RealName = "张三",
                // 证件号码
                IDCard = "M101198001201232",
                // 证件类型
                CardType = "passport",
                // 申请备注
                CommentApply = "申请免验证名单",
                // 平台企业 ID
                DealerID = config.DealerID,
                // 综合服务主体 ID
                BrokerID = config.BrokerID,
                // 证件照图片进行 Base64 编码后的字符串
                UserImages = new string[] { "igngudaere", "dfafdaea" },
                // 国别（地区）代码
                Country = "NOR",
                // 出生日期
                Birthday = "20010809",
                // 性别
                Gender = "男",
                // 审核完成后，接收异步通知的地址
                NotifyURL = "http://www.abcdef.com/api/notify",
                // 唯一流水号，回调时会附带
                Ref = "1234567890"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            UserExemptedInfoResponse res = client.Execute(request);

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

        // 查看免验证用户名单是否存在
        public static void UserWhiteCheck_Example()
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
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            UserWhiteCheckResponse res = client.Execute(request);

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
            //设置 App Key
            config.AppKey = "";
            //设置平台企业私钥
            config.PrivateKey = "";
            //设置云账户公钥
            config.YzhPublicKey = "";
            //设置 3DES Key
            config.Des3Key = "";
            //设置签名方式，rsa 或 sha256
            config.SignType = "";

            return config;
        }
    }
}
