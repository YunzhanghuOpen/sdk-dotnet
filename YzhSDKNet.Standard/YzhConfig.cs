using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Api
{
    /// <summary>
    /// 配置文件
    /// </summary>
    public class YzhConfig
    {
        /// <summary>
        /// 请求地址
        /// 线上：https://api-service.yunzhanghu.com
        /// 沙箱：https://api-service.yunzhanghu.com/sandbox
        /// 个体户注册：https://api-aic.yunzhanghu.com
        /// </summary>
        public string ServerUrl { get; set; } = "https://api-service.yunzhanghu.com";

        /// <summary>
        /// 平台企业 ID，必填
        /// </summary>
        public string DealerID { get; set; }

        /// <summary>
        /// 综合服务主体 ID，必填
        /// </summary>
        public string BrokerID { get; set; }

        /// <summary>
        /// App Key，必填
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 3DES Key，必填
        /// </summary>
        public string Des3Key { get; set; }

        /// <summary>
        /// 平台企业公钥
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// 平台企业私钥，签名类型为 rsa 时，必填
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// 云账户公钥，回调验签场景需要
        /// </summary>
        public string YzhPublicKey { get; set; }

        /// <summary>
        /// 签名方式，登录云账户综合服务平台，选择“业务中心 > 业务管理 > 对接信息”获取，默认为 RSA 签名
        /// RSA 签名：rsa | HMAC 签名：sha256
        /// </summary>
        public string SignType { get; set; } = "rsa";

    }
}
