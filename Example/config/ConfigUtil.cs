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
            // 请求域名
            // 生产环境请求域名
            config.ServerUrl = "https://api-service.yunzhanghu.com";
            // 沙箱环境请求域名
            // config.ServerUrl = "https://api-service.yunzhanghu.com/sandbox";
            // 个体工商户注册域名
            // config.ServerUrl = "https://api-aic.yunzhanghu.com";
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