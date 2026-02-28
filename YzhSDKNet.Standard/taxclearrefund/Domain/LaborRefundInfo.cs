using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 退补税劳动者明细
    /// </summary>
    public class LaborRefundInfo : AopObject
    {
        /// <summary>
        /// 劳动者姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        
        /// <summary>
        /// 劳动者证件号
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
        /// <summary>
        /// 本批次退补给劳动者税费总额
        /// </summary>
        [JsonProperty("refund_tax")]
        public string RefundTax { get; set; }
        
        /// <summary>
        /// 退补税状态
        /// </summary>
        [JsonProperty("tax_refund_status")]
        public string TaxRefundStatus { get; set; }
        
        /// <summary>
        /// 劳动者收款账户
        /// </summary>
        [JsonProperty("receiving_account")]
        public string ReceivingAccount { get; set; }
        
        /// <summary>
        /// 劳动者收款账号
        /// </summary>
        [JsonProperty("receiving_channel")]
        public string ReceivingChannel { get; set; }
        
        /// <summary>
        /// 退补税费时间
        /// </summary>
        [JsonProperty("refund_tax_finished_time")]
        public string RefundTaxFinishedTime { get; set; }
        
    }
}