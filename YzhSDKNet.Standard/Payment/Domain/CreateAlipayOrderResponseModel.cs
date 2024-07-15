using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 支付宝实时支付返回
    /// </summary>
    public class CreateAlipayOrderResponseModel : AopObject
    {
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
        /// 订单金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }

    }
}