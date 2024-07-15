using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 用户解约（测试账号专用接口）
    /// </summary>
    public class H5UserReleaseResponse : AopResponse
    {
        /// <summary>
        /// 用户解约（测试账号专用接口）
        /// </summary>
        [JsonProperty("data")]
        public H5UserReleaseResponseModel Data { get; set; }
        
    }
}