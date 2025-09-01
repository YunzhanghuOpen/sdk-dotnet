using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 缴税明细
    /// </summary>
    public class TaxDetail : AopObject
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
        
        /// <summary>
        /// 实纳个税
        /// </summary>
        [JsonProperty("received_personal_tax")]
        public string ReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 实纳增值税
        /// </summary>
        [JsonProperty("received_value_added_tax")]
        public string ReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 实纳附加税费
        /// </summary>
        [JsonProperty("received_additional_tax")]
        public string ReceivedAdditionalTax { get; set; }
        
    }
}