namespace Aop.Api
{
    /// <summary>
    /// 配置信息
    /// </summary>
    public class YzhConfig
    {
        /// <summary>
        /// 基础接口地址
        /// 生产环境：https://api-service.yunzhanghu.com
        /// 沙箱沙箱：https://api-service.yunzhanghu.com/sandbox
        /// 个体工商户注册：https://api-aic.yunzhanghu.com
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
        public string TripleDesKey { get; set; }

        /// <summary>
        /// 平台企业私钥，签名算法为 RSA 时，必填
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// 云账户公钥，签名算法为 RSA 时，回调验签场景必填
        /// </summary>
        public string YzhPublicKey { get; set; }

        /// <summary>
        /// 签名算法，登录云账户综合服务平台，在“业务中心 > 业务管理 > 对接信息”中进行查看
        /// 支持 RSA、HMAC，枚举分别为 rsa、sha256，默认为 RSA 签名算法
        /// </summary>
        public string SignType { get; set; } = "rsa";
    }
}
