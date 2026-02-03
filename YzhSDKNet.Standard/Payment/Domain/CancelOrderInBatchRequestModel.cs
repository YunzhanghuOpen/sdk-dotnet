using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 取消批次中单笔订单请求
    /// </summary>
    public class CancelOrderInBatchRequestModel : AopObject
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
        
        /// <summary>
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }
        
    }
}