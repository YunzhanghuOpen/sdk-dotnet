using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Aop.Api.Example
{
    public class Tax
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        // 设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒
        // client.SetTimeout(30000); 

        // 下载个人所得税扣缴明细表
        public static void GetTaxFile_Example()
        {

            // 实例化具体 API 对应的 request 类
            GetTaxFileRequest request = new GetTaxFileRequest();
            // 加载接口参数
            GetTaxFileRequestModel model = new GetTaxFileRequestModel
            {
                DealerID = config.DealerID,
                EntID = "accumulus_tj",
                YearMonth = "2023-01"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetTaxFileResponse res = client.Execute(request);

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

        // 查询纳税人是否为跨集团用户
        public static void GetUserCross_Example()
        { 

            // 实例化具体 API 对应的 request 类
            GetUserCrossRequest request = new GetUserCrossRequest();
            // 加载接口参数
            GetUserCrossRequestModel model = new GetUserCrossRequestModel
            {
                DealerID = config.DealerID,
                EntID = "accumulus_tj",
                Year = "2023",
                IDCard = "110101198010021201"
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID(""); 

            // 发起请求
            GetUserCrossResponse res = client.Execute(request);

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
