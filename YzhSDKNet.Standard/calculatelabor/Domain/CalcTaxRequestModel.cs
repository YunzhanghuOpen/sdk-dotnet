using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 订单税费试算请求
    /// </summary>
    public class CalcTaxRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }
        
        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }
        
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        
        /// <summary>
        /// 证件号
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
        /// <summary>
        /// 测算金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }
        
        /// <summary>
        /// 测算类型
        /// </summary>
        [JsonProperty("tax_type")]
        public string TaxType { get; set; }
        
        /// <summary>
        /// 税前订单金额返回值类型
        /// </summary>
        [JsonProperty("before_tax_amount_type")]
        public string BeforeTaxAmountType { get; set; }

    }
}