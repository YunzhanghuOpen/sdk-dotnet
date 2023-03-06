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
        /// 签名类型：rsa 或 sha256
        /// 云账户支持两种签名类型，rsa 或者 HMAC，其中HAMC签名传 sha256，rsa 签名类型传 rsa
        /// 新开通的平台企业默认使用 rsa 签名类型，如果需要切换可登录【云账户综合服务平台-业务中心-业务管理-对接信息】进行切换
        /// </summary>
        public string SignType { get; set; } = "rsa";

    }
}
