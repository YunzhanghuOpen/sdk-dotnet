using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 缴税明细
    /// </summary>
    public class TaxDetail : AopObject
    {
        /// <summary>
        /// 预扣个税
        /// </summary>
        [JsonProperty("personal_tax")]
        public string PersonalTax { get; set; }
        
        /// <summary>
        /// 预扣增值税
        /// </summary>
        [JsonProperty("value_added_tax")]
        public string ValueAddedTax { get; set; }
        
        /// <summary>
        /// 预扣附加税费
        /// </summary>
        [JsonProperty("additional_tax")]
        public string AdditionalTax { get; set; }
        
        /// <summary>
        /// 实缴个税
        /// </summary>
        [JsonProperty("received_personal_tax")]
        public string ReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 实缴增值税
        /// </summary>
        [JsonProperty("received_value_added_tax")]
        public string ReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 实缴附加税费
        /// </summary>
        [JsonProperty("received_additional_tax")]
        public string ReceivedAdditionalTax { get; set; }
        
        /// <summary>
        /// 劳动者预扣个税
        /// </summary>
        [JsonProperty("user_personal_tax")]
        public string UserPersonalTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣个税
        /// </summary>
        [JsonProperty("dealer_personal_tax")]
        public string DealerPersonalTax { get; set; }
        
        /// <summary>
        /// 劳动者预扣增值税
        /// </summary>
        [JsonProperty("user_value_added_tax")]
        public string UserValueAddedTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣增值税
        /// </summary>
        [JsonProperty("dealer_value_added_tax")]
        public string DealerValueAddedTax { get; set; }
        
        /// <summary>
        /// 劳动者预扣附加税费
        /// </summary>
        [JsonProperty("user_additional_tax")]
        public string UserAdditionalTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣附加税费
        /// </summary>
        [JsonProperty("dealer_additional_tax")]
        public string DealerAdditionalTax { get; set; }
        
        /// <summary>
        /// 劳动者实缴个税
        /// </summary>
        [JsonProperty("user_received_personal_tax")]
        public string UserReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴个税
        /// </summary>
        [JsonProperty("dealer_received_personal_tax")]
        public string DealerReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 劳动者实缴增值税
        /// </summary>
        [JsonProperty("user_received_value_added_tax")]
        public string UserReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴增值税
        /// </summary>
        [JsonProperty("dealer_received_value_added_tax")]
        public string DealerReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 劳动者实缴附加税费
        /// </summary>
        [JsonProperty("user_received_additional_tax")]
        public string UserReceivedAdditionalTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴附加税费
        /// </summary>
        [JsonProperty("dealer_received_additional_tax")]
        public string DealerReceivedAdditionalTax { get; set; }
        
        /// <summary>
        /// 预扣城建附加税
        /// </summary>
        [JsonProperty("additional_urban_tax")]
        public string AdditionalUrbanTax { get; set; }
        
        /// <summary>
        /// 预扣教育附加税
        /// </summary>
        [JsonProperty("additional_tuition_tax")]
        public string AdditionalTuitionTax { get; set; }
        
        /// <summary>
        /// 预扣地方教育附加税
        /// </summary>
        [JsonProperty("additional_local_tuition_tax")]
        public string AdditionalLocalTuitionTax { get; set; }
        
    }
}