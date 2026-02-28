using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询税费退补涉及劳动者请求
    /// </summary>
    public class GetRefundTaxLaborInfoRequestModel : AopObject
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
        /// 批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }
        
        /// <summary>
        /// 税款所属期
        /// </summary>
        [JsonProperty("tax_month")]
        public string TaxMonth { get; set; }
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
        
        /// <summary>
        /// 每页返回条数
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }
        
    }
}