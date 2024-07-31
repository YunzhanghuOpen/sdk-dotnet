using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 重试挂起状态订单请求
    /// </summary>
    public class RetryOrderRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }
        
        /// <summary>
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }
        
        /// <summary>
        /// 综合服务平台流水号
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }
        
        /// <summary>
        /// 支付路径名
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }
        
    }
}