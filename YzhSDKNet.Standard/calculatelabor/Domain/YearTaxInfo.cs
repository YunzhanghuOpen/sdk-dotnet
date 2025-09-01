using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 综合所得汇算清缴信息
    /// </summary>
    public class YearTaxInfo : AopObject
    {
        /// <summary>
        /// 连续劳务年度个税
        /// </summary>
        [JsonProperty("continuous_month_personal_tax")]
        public string ContinuousMonthPersonalTax { get; set; }
        
        /// <summary>
        /// 综合所得汇算清缴年度个税
        /// </summary>
        [JsonProperty("personal_tax")]
        public string PersonalTax { get; set; }
        
        /// <summary>
        /// 年度扣除费用
        /// </summary>
        [JsonProperty("deduct_cost")]
        public string DeductCost { get; set; }
        
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
        /// 税负率
        /// </summary>
        [JsonProperty("total_tax_rate")]
        public string TotalTaxRate { get; set; }
        
    }
}