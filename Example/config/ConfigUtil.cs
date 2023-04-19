using Aop.Api;

namespace Aop.Api.Example.config
{
    public class ConfigUtil
    {
        /// <summary>
        /// 配置基础信息
        /// </summary>
        /// <returns>基础信息</returns>
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
            // 平台企业私钥
            config.PrivateKey = "";
            // 云账户公钥
            config.YzhPublicKey = "";
            // 3DES Key
            config.TripleDesKey = "";
            // 签名方式，rsa 或 sha256
            config.SignType = "";

            return config;
        }
    }
}