using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 批次撤销请求
    /// </summary>
    public class CancelBatchOrderRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }

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

    }
}