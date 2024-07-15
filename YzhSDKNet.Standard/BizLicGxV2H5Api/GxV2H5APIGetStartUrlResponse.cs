using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 预启动
    /// </summary>
    public class GxV2H5APIGetStartUrlResponse : AopResponse
    {
        /// <summary>
        /// 预启动
        /// </summary>
        [JsonProperty("data")]
        public GxV2H5APIGetStartUrlResponseModel Data { get; set; }
        
    }
}