using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 订单税费试算返回
    /// </summary>
    public class CalcTaxResponseModel : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }
        
        /// <summary>
        /// 税费总额
        /// </summary>
        [JsonProperty("tax")]
        public string Tax { get; set; }
        
        /// <summary>
        /// 税后金额
        /// </summary>
        [JsonProperty("after_tax_amount")]
        public string AfterTaxAmount { get; set; }
        
        /// <summary>
        /// 税费明细
        /// </summary>
        [JsonProperty("tax_detail")]
        public CalcTaxDetail TaxDetail { get; set; }
        
    }
}