using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询税费退补涉及劳动者返回
    /// </summary>
    public class GetRefundTaxLaborInfoResponseModel : AopObject
    {
        /// <summary>
        /// 税款所属期
        /// </summary>
        [JsonProperty("tax_month")]
        public string TaxMonth { get; set; }
        
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }
        
        /// <summary>
        /// 批次生成时间
        /// </summary>
        [JsonProperty("batch_create_time")]
        public string BatchCreateTime { get; set; }
        
        /// <summary>
        /// 退补税劳动者数量
        /// </summary>
        [JsonProperty("labor_num")]
        public string LaborNum { get; set; }
        
        /// <summary>
        /// 退补税订单数量
        /// </summary>
        [JsonProperty("order_num")]
        public string OrderNum { get; set; }
        
        /// <summary>
        /// 总数据条数
        /// </summary>
        [JsonProperty("total_num")]
        public string TotalNum { get; set; }
        
        /// <summary>
        /// 退补税劳动者明细
        /// </summary>
        [JsonProperty("labor_refund_info")]
        public LaborRefundInfo[] LaborRefundInfo { get; set; }
        
    }
}