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
        public string TripleDesKey { get; set; }

        /// <summary>
        /// 平台企业私钥，签名方式为 rsa 时，必填
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
