using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 取消批次中单笔订单
    /// </summary>
    public class CancelOrderInBatchResponse : AopResponse
    {
        /// <summary>
        /// 取消批次中单笔订单
        /// </summary>
        [JsonProperty("data")]
        public CancelOrderInBatchResponseModel Data { get; set; }
        
    }
}