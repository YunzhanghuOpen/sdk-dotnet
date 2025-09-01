using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 月度税务信息
    /// </summary>
    public class MontTax : AopObject
    {
        /// <summary>
        /// 月份
        /// </summary>
        [JsonProperty("month")]
        public int Month { get; set; }
        
        /// <summary>
        /// 含增值税收入
        /// </summary>
        [JsonProperty("pre_tax_amount")]
        public string PreTaxAmount { get; set; }
        
        /// <summary>
        /// 不含增值税收入
        /// </summary>
        [JsonProperty("excluding_vat_amount")]
        public string ExcludingVatAmount { get; set; }
        
        /// <summary>
        /// 增值税
        /// </summary>
        [JsonProperty("value_added_tax")]
        public string ValueAddedTax { get; set; }
        
        /// <summary>
        /// 附加税
        /// </summary>
        [JsonProperty("additional_tax")]
        public string AdditionalTax { get; set; }
        
        /// <summary>
        /// 个税
        /// </summary>
        [JsonProperty("personal_tax")]
        public string PersonalTax { get; set; }
        
        /// <summary>
        /// 个税税率
        /// </summary>
        [JsonProperty("personal_tax_rate")]
        public string PersonalTaxRate { get; set; }
        
        /// <summary>
        /// 速算扣除数
        /// </summary>
        [JsonProperty("deduct_tax")]
        public string DeductTax { get; set; }
        
        /// <summary>
        /// 税后金额
        /// </summary>
        [JsonProperty("post_tax_amount")]
        public string PostTaxAmount { get; set; }
        
        /// <summary>
        /// 税负率
        /// </summary>
        [JsonProperty("total_tax_rate")]
        public string TotalTaxRate { get; set; }
        
    }
}