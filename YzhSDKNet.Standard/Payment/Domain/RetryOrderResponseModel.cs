using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 重试挂起状态订单返回
    /// </summary>
    public class RetryOrderResponseModel : AopObject
    {
        /// <summary>
        /// 请求标识
        /// </summary>
        [JsonProperty("ok")]
        public string Ok { get; set; }
        
    }
}