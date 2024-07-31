using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查看用户是否在非居民身份证验证名单中
    /// </summary>
    public class UserWhiteCheckResponse : AopResponse
    {
        /// <summary>
        /// 查看用户是否在非居民身份证验证名单中
        /// </summary>
        [JsonProperty("data")]
        public UserWhiteCheckResponseModel Data { get; set; }
        
    }
}