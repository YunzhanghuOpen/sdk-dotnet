using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询日订单数据（支付和退款订单）
    /// </summary>
    public class ListDailyOrderV2Response : AopResponse
    {
        /// <summary>
        /// 查询日订单数据（支付和退款订单）
        /// </summary>
        [JsonProperty("data")]
        public ListDailyOrderV2ResponseModel Data { get; set; }
        
    }
}