using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 税费明细
    /// </summary>
    public class CalcTaxDetail : AopObject
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
        /// 云账户预扣个税
        /// </summary>
        [JsonProperty("broker_personal_tax")]
        public string BrokerPersonalTax { get; set; }
        
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
        /// 云账户预扣增值税
        /// </summary>
        [JsonProperty("broker_value_added_tax")]
        public string BrokerValueAddedTax { get; set; }
        
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
        /// 云账户预扣附加税费
        /// </summary>
        [JsonProperty("broker_additional_tax")]
        public string BrokerAdditionalTax { get; set; }
        
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