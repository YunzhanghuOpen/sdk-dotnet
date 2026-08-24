using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询劳动者退款订单信息请求
    /// </summary>
    public class GetLaborRefundOrderRequestModel : AopObject
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
        /// 支付路径
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

    }
}
