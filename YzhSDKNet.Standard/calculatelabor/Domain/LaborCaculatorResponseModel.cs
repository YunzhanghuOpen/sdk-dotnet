using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 连续劳务税费试算（计算器）返回
    /// </summary>
    public class LaborCaculatorResponseModel : AopObject
    {
        /// <summary>
        /// 综合所得汇算清缴
        /// </summary>
        [JsonProperty("year_tax_info")]
        public YearTaxInfo YearTaxInfo { get; set; }
        
        /// <summary>
        /// 月度税务信息列表
        /// </summary>
        [JsonProperty("month_tax_list")]
        public MontTax[] MonthTaxList { get; set; }
        
    }
}