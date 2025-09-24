using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 连续劳务年度税费测算-H5
    /// </summary>
    public class CalculationYearH5UrlResponse : AopResponse
    {
        /// <summary>
        /// 连续劳务年度税费测算-H5
        /// </summary>
        [JsonProperty("data")]
        public CalculationYearH5UrlResponseModel Data { get; set; }
        
    }
}