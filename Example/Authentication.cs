using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class Authentication
    {
        //获取基础配置信息
        public static YzhConfig GetConfig()
        {
            YzhConfig config = new YzhConfig();
            config.ServerUrl = ""; //设置接口基础地址
            config.DealerID = ""; //设置平台企业 ID
            config.BrokerID = ""; //设置综合服务主体 ID
            config.AppKey = ""; //设置 App Key
            config.PrivateKey = ""; //设置平台企业私钥
            config.YzhPublicKey = ""; //设置云账户公钥
            config.Des3Key = ""; //设置 3DES Key
            config.SignType = ""; //设置签名方式，RSA 或 SHA256

            return config;

        }

        //身份实名验证
        public void IDCardVerify_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new IDCardVerifyRequest();
            //加载接口参数
            var model = new IDCardVerifyRequestModel
            {
                IDCard = "110101198001221211",
                RealName = "张三"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //银行卡信息查询
        public void GetBankCardInfo_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new GetBankCardInfoRequest();
            //加载接口参数
            var model = new GetBankCardInfoRequestModel
            {
                CardNo = "1234568987645212321",
                BankName = "招商银行"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //银行卡三要素验证
        public void BankCardThreeVerify_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new BankCardThreeVerifyRequest();
            //加载接口参数
            var model = new BankCardThreeVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //银行卡四要素验证
        public void BankCardFourVerify_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new BankCardFourVerifyRequest();
            //加载接口参数
            var model = new BankCardFourVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //银行卡四要素鉴权请求（下发短信验证码）
        public void BankCardFourAuthVerify_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new BankCardFourAuthVerifyRequest();
            //加载接口参数
            var model = new BankCardFourAuthVerifyRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //银行卡四要素确认请求（上传短信验证码）
        public void BankCardFourAuthConfirm_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new BankCardFourAuthConfirmRequest();
            //加载接口参数
            var model = new BankCardFourAuthConfirmRequestModel
            {
                RealName = "张三",
                IDCard = "110101198001201232",
                CardNo = "1234568987645212321",
                Mobile = "18888888888",
                Captcha = "12345",
                Ref = "1234567890"
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //上传免验证用户名单信息
        public void UserExemptedInfo_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new UserExemptedInfoRequest();
            //加载接口参数
            var model = new UserExemptedInfoRequestModel
            {
                RealName = "张三", //姓名
                IDCard = "M101198001201232", //证件号码
                CardType = "passport", //证件类型
                CommentApply = "申请免验证名单", //申请备注
                DealerID = config.DealerID, //平台企业 ID
                BrokerID = config.BrokerID, //综合服务主体 ID
                UserImages = new string[] { "igngudaere", "dfafdaea" }, //证件照图片进行 Base64 编码后的字符串
                Country = "NOR", //国别（地区）代码
                Birthday = "20010809", //出生日期
                Gender = "男", //性别
                NotifyURL = "http://www.abcdef.com/api/notify", //审核完成后，接收异步通知的地址
                Ref = "1234567890" //唯一流水号，回调时会附带
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }

        //查看免验证用户名单是否存在
        public void UserWhiteCheck_Example()
        {
            //获取基础配置信息
            YzhConfig config = GetConfig();
            //客户端实现
            var client = new DefaultAopClient(config);
            //client.SetTimeout(30000); //设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒

            //实例化具体 API 对应的 request 类
            var request = new UserWhiteCheckRequest();
            //加载接口参数
            var model = new UserWhiteCheckRequestModel
            {
                RealName = "张三", //姓名
                IDCard = "M101198001201232", //证件号码
            };
            request.SetBizModel(model);
            //request.SetRequestID(""); //设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成

            //发起请求
            var res = client.Execute(request);
            Console.WriteLine(res.Code + "\n" + res.Message + "\n" + res.Body);
            if (res.Code == "0000")
            {
                //根据响应码进行业务处理
            }
        }
    }
}
