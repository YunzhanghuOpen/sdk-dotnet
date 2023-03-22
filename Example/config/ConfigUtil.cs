
using System;
using Aop.Api;


namespace Aop.Api.Example.config
{
    public class ConfigUtil
    {
        /// <summary>
        /// 获取取基础信息配置
        /// </summary>
        /// <returns></returns>
        public static YzhConfig GetConfig()
        {
            YzhConfig config = new YzhConfig();
            // 设置接口基础地址
            config.ServerUrl = "";
            // 设置平台企业 ID
            config.DealerID = "";
            // 设置综合服务主体 ID
            config.BrokerID = "";
            // 设置 App Key
            config.AppKey = "";
            // 设置平台企业私钥
            config.PrivateKey = "";
            // 设置云账户公钥
            config.YzhPublicKey = "";
            // 设置 3DES Key
            config.Des3Key = "";
            // 设置签名方式，rsa 或 sha256
            config.SignType = "";

            return config;
        }
    }
}