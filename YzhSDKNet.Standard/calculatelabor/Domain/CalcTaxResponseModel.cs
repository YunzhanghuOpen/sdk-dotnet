using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 订单税费试算返回
    /// </summary>
    public class CalcTaxResponseModel : AopObject
    {
        /// <summary>
        /// 测算金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }
        
        /// <summary>
        /// 税费总额
        /// </summary>
        [JsonProperty("tax")]
        public string Tax { get; set; }
        
        /// <summary>
        /// 税后结算金额
        /// </summary>
        [JsonProperty("after_tax_amount")]
        public string AfterTaxAmount { get; set; }
        
        /// <summary>
        /// 缴税明细
        /// </summary>
        [JsonProperty("tax_detail")]
        public CalcTaxDetail TaxDetail { get; set; }
        
        /// <summary>
        /// 税前订单金额
        /// </summary>
        [JsonProperty("before_tax_amount")]
        public string BeforeTaxAmount { get; set; }
        
        /// <summary>
        /// 用户税费总额
        /// </summary>
        [JsonProperty("user_tax")]
        public string UserTax { get; set; }
        
        /// <summary>
        /// 平台企业税费总额
        /// </summary>
        [JsonProperty("dealer_tax")]
        public string DealerTax { get; set; }
        
        /// <summary>
        /// 云账户税费总额
        /// </summary>
        [JsonProperty("broker_tax")]
        public string BrokerTax { get; set; }
        
        /// <summary>
        /// 用户服务费
        /// </summary>
        [JsonProperty("user_fee")]
        public string UserFee { get; set; }
        
        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// 结果详细状态码
        /// </summary>
        [JsonProperty("status_detail")]
        public string StatusDetail { get; set; }
        
        /// <summary>
        /// 结果说明
        /// </summary>
        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }
        
        /// <summary>
        /// 结果详细状态码描述
        /// </summary>
        [JsonProperty("status_detail_message")]
        public string StatusDetailMessage { get; set; }
        
        /// <summary>
        /// 用户实收金额（未扣除追缴的增附税）
        /// </summary>
        [JsonProperty("user_real_excluding_vat_amount")]
        public string UserRealExcludingVatAmount { get; set; }
        
        /// <summary>
        /// 用户还未缴清的增附税
        /// </summary>
        [JsonProperty("user_remaining_repayment_amount")]
        public string UserRemainingRepaymentAmount { get; set; }
        
        /// <summary>
        /// 已追缴增附税（本笔订单）
        /// </summary>
        [JsonProperty("user_recover_tax_amount")]
        public string UserRecoverTaxAmount { get; set; }
        
        /// <summary>
        /// 待追缴增附税总金额
        /// </summary>
        [JsonProperty("user_total_recover_tax_amount")]
        public string UserTotalRecoverTaxAmount { get; set; }
        
    }
}