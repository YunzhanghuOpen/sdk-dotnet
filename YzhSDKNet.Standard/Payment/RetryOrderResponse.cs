using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 重试挂起状态订单
    /// </summary>
    public class RetryOrderResponse : AopResponse
    {
        /// <summary>
        /// 重试挂起状态订单
        /// </summary>
        [JsonProperty("data")]
        public RetryOrderResponseModel Data { get; set; }
        
    }
}