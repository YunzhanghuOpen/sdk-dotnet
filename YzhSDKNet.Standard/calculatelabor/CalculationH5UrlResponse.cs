using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 连续劳务单笔结算税费测算-H5
    /// </summary>
    public class CalculationH5UrlResponse : AopResponse
    {
        /// <summary>
        /// 连续劳务单笔结算税费测算-H5
        /// </summary>
        [JsonProperty("data")]
        public CalculationH5UrlResponseModel Data { get; set; }
        
    }
}