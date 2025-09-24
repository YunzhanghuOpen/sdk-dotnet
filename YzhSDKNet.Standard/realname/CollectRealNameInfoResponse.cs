using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 用户实名认证信息收集
    /// </summary>
    public class CollectRealNameInfoResponse : AopResponse
    {
        /// <summary>
        /// 用户实名认证信息收集
        /// </summary>
        [JsonProperty("data")]
        public CollectRealNameInfoResponseModel Data { get; set; }
        
    }
}