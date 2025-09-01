using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 月度收入
    /// </summary>
    public class MonthSettlement : AopObject
    {
        /// <summary>
        /// 月份
        /// </summary>
        [JsonProperty("month")]
        public int Month { get; set; }
        
        /// <summary>
        /// 月度收入
        /// </summary>
        [JsonProperty("month_pre_tax_amount")]
        public string MonthPreTaxAmount { get; set; }
        
    }
}