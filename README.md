
# 云账户 SDK for DotNet

欢迎使用云账户 SDK for DotNet。   
云账户是一家专注为平台企业和新就业形态劳动者提供高质量灵活就业服务的新时代企业。云账户 SDK 对云账户综合服务平台 API 接口进行封装，让您不必关心过多参数请求，帮助您快速接入到云账户综合服务平台。云账户 SDK for DotNet 为您提供签约、下单、回调、数据查询等功能，帮助您完成与云账户综合服务平台的接口对接及业务开发。   
如果您在使用过程中遇到任何问题，欢迎在当前 GitHub 提交 Issues，或发送邮件至技术支持组 [techsupport@yunzhanghu.com](mailto:techsupport@yunzhanghu.com)。

## 环境要求

云账户 SDK for DotNet 支持.Net Framework 4.6.1、.Net Core 2.0及其以上版本。


## 配置密钥
### 1、获取配置

使用云账户 SDK for DotNet 前，您需先获取 dealer_id、broker_id、3DES Key、App Key 信息。   
获取方式：使用开户邮件中的账号登录[【云账户综合服务平台】](https://service.yunzhanghu.com)，选择“业务中心 > 业务管理 > 对接信息”，查看并获取以上配置信息。
![配置平台企业公钥信息](https://yos.yunzhanghu.com/getobject/duijiexinxi.png?isAttachment=false&fileID=9487bd54b93a5abf49003c2b8ce7e069bfa24220&signature=X%2BR7PocQgPqSpR2xM1TgYU6lAapr%2FB9p3aFof03Gcfw%3D)

### 2、生成密钥

- 方式一：使用 OpenSSL 生成 RSA 公私钥

```
① ⽣成私钥 private_key.pem

Openssl-> genrsa -out private_key.pem 2048   // 建议密钥⻓度⾄少为 2048 位

② ⽣成公钥 pubkey.pem

Openssl-> rsa -in private_key.pem -pubout -out pubkey.pem
```

- 方式二：使用工具生成

登录【[云账户开放平台](https://open.yunzhanghu.com/)】，选择“开发工具下载 > 开发助手 > 工具下载”，下载安装“云账户开放平台开发助手”。
注意：需使用Pkcs#1格式的RSA密钥对。


### 3、配置密钥

登录[【云账户综合服务平台】](https://service.yunzhanghu.com)，选择"业务中心 > 业务管理 > 对接信息"，单击页面右上角的"编辑"，配置平台企业公钥。
![配置平台企业公钥信息](https://yos.yunzhanghu.com/getobject/dujiexinxi-2.png?isAttachment=false&fileID=84e3cd1684a61c1e32eb0e7b7f43390cd053206b&signature=mqW8Zbk7h3gYXfzjR99pK%2B0pgVLcLly3VjBB2KsqDvQ%3D)


## 安装 DotNet SDK

NuGet 依赖，请参考：https://learn.microsoft.com/zh-cn/nuget/install-nuget-client-tools

## 快速使用

### 示例功能列表

- [H5 签约](Example/H5UserSign.cs) or [API 签约](Example/ApiUserSign.cs)
- [实时下单接口](Example/Payment.cs)
- [数据接口](Example/DataService.cs)
- [发票接口](Example/Invoice.cs)
- [个税扣缴明细表下载接口](Example/Tax.cs)
- [用户信息验证接口](Example/Authentication.cs)


### 示例
```C#
using System;
using Aop.Api.Domain;
using Aop.Api.Request;

namespace Aop.Api.Example
{
    public class Payment
    {
        // 获取基础配置信息
        static YzhConfig config = GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);
        // 设置接口超时时间，单位毫秒，SDK 中默认设置超时时间为 30 秒
        // client.SetTimeout(30000);

        //银行卡实时支付
        public static void CreateBankpayOrder_Example()
        {
            // 实例化具体 API 对应的 request 类
            CreateBankpayOrderRequest request = new CreateBankpayOrderRequest();
            // 加载接口参数
            CreateBankpayOrderRequestModel model = new CreateBankpayOrderRequestModel
            {
                DealerID = config.DealerID,
                BrokerID = config.BrokerID,
                OrderID = "test1234567890",
                RealName = "张三",
                IDCard = "110101198012021002",
                CardNo = "231326472361746231",
                PhoneNo = "",
                Pay = "100.25",
                PayRemark = "测试备注",
                NotifyURL = ""
            };
            request.SetBizModel(model);
            // 设置request-id，建议平台企业设置并保存，如未进行设置则使用 SDK 中的 GUID 方法自动生成
            // request.SetRequestID("");

            // 发起请求
            CreateBankpayOrderResponse res = client.Execute(request);

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
```
