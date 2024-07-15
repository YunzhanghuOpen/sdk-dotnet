using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询日订单文件（支付和退款订单）
    /// </summary>
    public class GetDailyOrderFileV2Response : AopResponse
    {
        /// <summary>
        /// 查询日订单文件（支付和退款订单）
        /// </summary>
        [JsonProperty("data")]
        public GetDailyOrderFileV2ResponseModel Data { get; set; }
        
    }
}