# 云账户 SDK for .Net

欢迎使用云账户 SDK for .Net。  
云账户是一家专注为平台企业和新就业形态劳动者提供高质量灵活就业服务的新时代企业。云账户 SDK 对云账户综合服务平台 API 接口进行封装，帮助您快速接入到云账户综合服务平台。云账户 SDK for .Net 为您提供签约、支付、回调、数据查询等功能，帮助您完成与云账户综合服务平台的接口对接及业务开发。  
如果您在使用过程中遇到任何问题，请在当前 GitHub 提交 Issues，或发送邮件至技术支持组 [technicalsupport@yunzhanghu.com](mailto:technicalsupport@yunzhanghu.com)。

### 环境要求

云账户 SDK for .Net 支持.Net Framework 4.6.1、.Net Core 2.0 及以上版本。

### 配置密钥

#### 1、获取配置

使用云账户 SDK for .Net 前，您需先获取 dealer_id、broker_id、3DES Key、App Key、云账户公钥。   
获取方式：使用开户邮件中的账号登录【[云账户综合服务平台](https://service.yunzhanghu.com)】，选择“业务中心 > 业务管理 > 对接信息”，查看并获取以上配置信息。  
![获取配置信息](https://yos.yunzhanghu.com/getobject/2025-02-10-duijiexinxi.png?isAttachment=false&fileID=aed58af41aedcc178a160094cf57bea52b5ead65&signature=FGeLvvOykgSldgmDzR%2F%2FxLDH%2FDL049Bz5OWR8XnyohE%3D)

#### 2、生成密钥

- 方式一：使用 OpenSSL 生成 RSA 公私钥

```
① ⽣成私钥 private_key.pem

OpenSSL-> genrsa -out private_key.pem 2048   // 建议密钥⻓度⾄少为 2048 位

② ⽣成公钥 pubkey.pem

OpenSSL-> rsa -in private_key.pem -pubout -out pubkey.pem

```

- 方式二：使用工具生成

登录【[云账户开放平台](https://open.yunzhanghu.com/)】，选择“开发工具下载 > 开发助手 > 工具下载”，下载安装“云账户开放平台开发助手”

#### 3、配置密钥

登录【[云账户综合服务平台](https://service.yunzhanghu.com)】，选择“业务中心 > 业务管理 > 对接信息”，单击页面右上角的“编辑”，配置平台企业公钥。
![配置平台企业公钥信息](https://yos.yunzhanghu.com/getobject/2025-02-11-dealerpublickey.png?isAttachment=false&fileID=6359c3b70c1a93aad5d230c76095a8baa61f4627&signature=pDmxtJYTn9Rghn1POO3XAWHXo1wIBenFXAu9ABEyGbk%3D)

### 安装 .Net SDK
- 方式一：通过 NuGet 程序包管理器安装（推荐）

以 Visual Studio 2022 为例  
① 在解决方案资源管理器面板中右键“项目”，选择“管理 NuGet 包”  
② 在“NuGet 包管理器”窗口中，默认选择“nuget.org”作为包源  
③ 在“浏览”选项卡中，搜索 YzhSDKNet.Standard，在搜索结果列表中选择 YzhSDKNet.Standard，然后点击“安装”

- 方式二：通过 .NET CLI 工具来安装

执行命令： 
> dotnet add package YzhSDKNet.Standard


详情参考：[https://learn.microsoft.com/zh-cn/nuget/install-nuget-client-tools](https://learn.microsoft.com/zh-cn/nuget/install-nuget-client-tools)

### 快速使用

#### 示例功能列表

- [用户信息验证](Example/Authentication.cs)
- 用户签约
   - [H5 签约](Example/H5UserSign.cs)
   - [API 签约](Example/ApiUserSign.cs)
   - [签约信息上传](Example/UploadUserSign.cs)
- 个体工商户注册
   - [云账户新经济 H5](Example/BizLicXjjH5.cs)
   - [云账户新经济 H5+API](Example/BizLicXjjH5Api.cs) 
- [实时支付](Example/Payment.cs)
- [对账文件获取](Example/DataService.cs)
- [发票开具](Example/Invoice.cs)
- [个人所得税申报明细表](Example/Tax.cs)



### 示例
```C#
using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Aop.Api.Example
{
    public class Payment
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();

        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);

        // 单笔支付（银行卡实时支付）
        public static void CreateBankpayOrder()
        {
            // 实例化具体 API 对应的 request 类
            CreateBankpayOrderRequest request = new CreateBankpayOrderRequest();

            // 配置请求参数
            CreateBankpayOrderRequestModel model = new CreateBankpayOrderRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "11010519491231002X",
                CardNo = "6228888888888888888",
                PhoneNo = "188****8888",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = "https://www.example.com"
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 设置超时时间。非必填，默认 30 秒
            // client.SetTimeout(30 * 1000);

            // 发起请求
            try
            {
                CreateBankpayOrderResponse res = client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CreateBankpayOrderResponseModel data = res.Data;
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

        // 获取基础配置信息
        public static YzhConfig GetConfig()
        {
            YzhConfig config = new YzhConfig();
            // 基础接口地址
            config.ServerUrl = "";
            // 平台企业 ID
            config.DealerID = "";
            // 综合服务主体 ID
            config.BrokerID = "";
            // App Key
            config.AppKey = "";
            // 3DES Key
            config.TripleDesKey = "";
            // 平台企业私钥
            config.PrivateKey = "";
            // 云账户公钥
            config.YzhPublicKey = "";
            // 签名算法为 RSA，参数固定为：rsa
            config.SignType = "rsa";

            return config;
        }
    }
}
```
