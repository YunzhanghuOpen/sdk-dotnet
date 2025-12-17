using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 连续劳务税费退补完成数据
    /// </summary>
    public class RefundTaxData : AopObject
    {
        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }
        
        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }
        
        /// <summary>
        /// 清缴次数
        /// </summary>
        [JsonProperty("tax_clear_num")]
        public string TaxClearNum { get; set; }
        
        /// <summary>
        /// 报税属期
        /// </summary>
        [JsonProperty("tax_month")]
        public string TaxMonth { get; set; }
        
        /// <summary>
        /// 退补税用户数量
        /// </summary>
        [JsonProperty("refund_tax_labor_num")]
        public string RefundTaxLaborNum { get; set; }
        
        /// <summary>
        /// 退补税订单数量
        /// </summary>
        [JsonProperty("refund_tax_order_num")]
        public string RefundTaxOrderNum { get; set; }
        
        /// <summary>
        /// 订单总金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
        
        /// <summary>
        /// 本批次退补税费总额
        /// </summary>
        [JsonProperty("cur_total_refund_tax")]
        public string CurTotalRefundTax { get; set; }
        
        /// <summary>
        /// 退补税费总额
        /// </summary>
        [JsonProperty("total_refund_tax")]
        public string TotalRefundTax { get; set; }
        
        /// <summary>
        /// 历史已退补税费总额
        /// </summary>
        [JsonProperty("history_refund_tax")]
        public string HistoryRefundTax { get; set; }
        
        /// <summary>
        /// 本批次预扣税费总额
        /// </summary>
        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }
        
        /// <summary>
        /// 本批次实缴税费总额
        /// </summary>
        [JsonProperty("receive_total_tax")]
        public string ReceiveTotalTax { get; set; }
        
        /// <summary>
        /// 本批次退补给用户税费总额
        /// </summary>
        [JsonProperty("cur_total_refund_labor_tax")]
        public string CurTotalRefundLaborTax { get; set; }
        
        /// <summary>
        /// 本批次退补给平台企业税费总额
        /// </summary>
        [JsonProperty("cur_total_refund_dealer_tax")]
        public string CurTotalRefundDealerTax { get; set; }
        
        /// <summary>
        /// 本批次退补给云账户税费总额
        /// </summary>
        [JsonProperty("cur_total_refund_broker_tax")]
        public string CurTotalRefundBrokerTax { get; set; }
        
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }
        
        /// <summary>
        /// 批次退补税状态
        /// </summary>
        [JsonProperty("batch_refund_tax_status")]
        public string BatchRefundTaxStatus { get; set; }
        
        /// <summary>
        /// 批次生成时间
        /// </summary>
        [JsonProperty("batch_create_time")]
        public string BatchCreateTime { get; set; }
        
        /// <summary>
        /// 批次退补税成功时间
        /// </summary>
        [JsonProperty("batch_refund_tax_finished_time")]
        public string BatchRefundTaxFinishedTime { get; set; }
        
        /// <summary>
        /// 已完成税费退补的用户数量
        /// </summary>
        [JsonProperty("refund_tax_finished_labor_num")]
        public string RefundTaxFinishedLaborNum { get; set; }
        
        /// <summary>
        /// 已完成的税费退补总额
        /// </summary>
        [JsonProperty("refund_tax_finished_amount")]
        public string RefundTaxFinishedAmount { get; set; }
        
    }
}