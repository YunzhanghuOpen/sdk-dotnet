using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询日订单文件（支付和退款订单）请求
    /// </summary>
    public class GetDailyOrderFileV2RequestModel : AopObject
    {
        /// <summary>
        /// 订单查询日期, 格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty("order_date")]
        public string OrderDate { get; set; }

    }
}