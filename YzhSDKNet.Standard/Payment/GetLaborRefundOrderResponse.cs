using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询劳动者退款订单信息
    /// </summary>
    public class GetLaborRefundOrderResponse : AopResponse
    {
        /// <summary>
        /// 查询劳动者退款订单信息
        /// </summary>
        [JsonProperty("data")]
        public GetLaborRefundOrderResponseModel Data { get; set; }

    }
}
