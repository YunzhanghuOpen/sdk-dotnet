using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查看用户是否在非居民身份证验证名单中返回
    /// </summary>
    public class UserWhiteCheckResponseModel : AopObject
    {
        /// <summary>
        /// ok
        /// </summary>
        [JsonProperty("ok")]
        public bool Ok { get; set; }

    }
}