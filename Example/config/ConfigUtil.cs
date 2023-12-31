using Aop.Api;

namespace Aop.Api.Example.Config
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