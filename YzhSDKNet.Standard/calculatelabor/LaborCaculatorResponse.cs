using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 连续劳务税费试算（计算器）
    /// </summary>
    public class LaborCaculatorResponse : AopResponse
    {
        /// <summary>
        /// 连续劳务税费试算（计算器）
        /// </summary>
        [JsonProperty("data")]
        public LaborCaculatorResponseModel Data { get; set; }
        
    }
}