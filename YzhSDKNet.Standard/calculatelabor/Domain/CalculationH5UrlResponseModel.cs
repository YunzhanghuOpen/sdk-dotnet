using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 连续劳务单笔结算税费测算-H5 返回
    /// </summary>
    public class CalculationH5UrlResponseModel : AopObject
    {
        /// <summary>
        /// 连续劳务单笔结算税费测算 H5 页面 URL
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        
    }
}