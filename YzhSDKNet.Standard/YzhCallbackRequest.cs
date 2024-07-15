using Newtonsoft.Json;

namespace Aop.Api
{
    /// <summary>
    /// 云账户回调实体
    /// </summary>
    /// <typeparam name="T">回调对象</typeparam>
    public class YzhCallbackRequest<T>
        where T : AopObject
    {
        /// <summary>
        /// 回调信息密文
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 随机数
        /// </summary>
        [JsonProperty("mess")]
        public string Mess { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 签名算法，支持 RSA、HMAC，枚举分别为 rsa、sha256
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }
        
    }
}