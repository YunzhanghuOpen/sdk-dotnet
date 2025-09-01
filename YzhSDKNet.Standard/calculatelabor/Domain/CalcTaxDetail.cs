using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 税费明细
    /// </summary>
    public class CalcTaxDetail : AopObject
    {
        /// <summary>
        /// 应纳个税
        /// </summary>
        [JsonProperty("personal_tax")]
        public string PersonalTax { get; set; }
        
        /// <summary>
        /// 应纳增值税
        /// </summary>
        [JsonProperty("value_added_tax")]
        public string ValueAddedTax { get; set; }
        
        /// <summary>
        /// 应纳附加税费
        /// </summary>
        [JsonProperty("additional_tax")]
        public string AdditionalTax { get; set; }
        
    }
}