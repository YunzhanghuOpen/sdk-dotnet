using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectRealNameInfoResponse
    /// </summary>
    public class CollectRealNameInfoResponseModel : AopObject
    {
        /// <summary>
        /// 录入状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
    }
}