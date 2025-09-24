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
        /// 用户预扣个税
        /// </summary>
        [JsonProperty("user_personal_tax")]
        public string UserPersonalTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣个税
        /// </summary>
        [JsonProperty("dealer_personal_tax")]
        public string DealerPersonalTax { get; set; }
        
        /// <summary>
        /// 用户预扣增值税
        /// </summary>
        [JsonProperty("user_value_added_tax")]
        public string UserValueAddedTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣增值税
        /// </summary>
        [JsonProperty("dealer_value_added_tax")]
        public string DealerValueAddedTax { get; set; }
        
        /// <summary>
        /// 用户预扣附加税费
        /// </summary>
        [JsonProperty("user_additional_tax")]
        public string UserAdditionalTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣附加税费
        /// </summary>
        [JsonProperty("dealer_additional_tax")]
        public string DealerAdditionalTax { get; set; }
        
        /// <summary>
        /// 用户实缴个税
        /// </summary>
        [JsonProperty("user_received_personal_tax")]
        public string UserReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴个税
        /// </summary>
        [JsonProperty("dealer_received_personal_tax")]
        public string DealerReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 用户实缴增值税
        /// </summary>
        [JsonProperty("user_received_value_added_tax")]
        public string UserReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴增值税
        /// </summary>
        [JsonProperty("dealer_received_value_added_tax")]
        public string DealerReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 用户实缴附加税费
        /// </summary>
        [JsonProperty("user_received_additional_tax")]
        public string UserReceivedAdditionalTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴附加税费
        /// </summary>
        [JsonProperty("dealer_received_additional_tax")]
        public string DealerReceivedAdditionalTax { get; set; }
        
        /// <summary>
        /// 预扣个税税率
        /// </summary>
        [JsonProperty("personal_tax_rate")]
        public string PersonalTaxRate { get; set; }
        
        /// <summary>
        /// 预扣个税速算扣除数
        /// </summary>
        [JsonProperty("deduct_tax")]
        public string DeductTax { get; set; }
        
    }
}