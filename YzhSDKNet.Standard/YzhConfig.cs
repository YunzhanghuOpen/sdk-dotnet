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
        /// </summary>
        public string ServerUrl { get; set; } = "https://api-service.yunzhanghu.com";

        /// <summary>
        /// 平台企业 ID，必填
        /// </summary>
        public string DealerID { get; set; }

        /// <summary>
        /// 云账户分配的 APP KEY，必填
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 云账户分配的 DES3 KEY，必填
        /// </summary>
        public string Des3Key { get; set; }

        /// <summary>
        /// 平台企业公钥
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// 平台企业私钥，RSA签名类型必填
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// 云账户公钥，回调验签场景需要
        /// </summary>
        public string YzhPublicKey { get; set; }

        /// <summary>
        /// 签名类型 RSA OR SHA256
        /// 云账户支持两种签名类型，RSA 或者 HMAC，其中HAMC签名传SHA256，RSA签名类型传RSA
        /// 新开通的平台企业默认使用 RSA 签名类型，如果需要切换请联系对应云账户支持
        /// </summary>
        public string SignType { get; set; } = "RSA";

    }
}
