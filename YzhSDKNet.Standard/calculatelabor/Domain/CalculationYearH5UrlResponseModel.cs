using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 连续劳务年度税费测算-H5 返回
    /// </summary>
    public class CalculationYearH5UrlResponseModel : AopObject
    {
        /// <summary>
        /// 年度劳务测算 H5 页面 URL
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        
    }
}