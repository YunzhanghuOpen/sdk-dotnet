using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询税费清缴明细文件请求
    /// </summary>
    public class GetClearTaxFileRequestModel : AopObject
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
        /// 报税属期
        /// </summary>
        [JsonProperty("tax_month")]
        public string TaxMonth { get; set; }
        
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }
        
    }
}