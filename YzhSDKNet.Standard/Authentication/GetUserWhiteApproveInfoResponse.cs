using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 非居民身份证验证名单审核结果查询
    /// </summary>
    public class GetUserWhiteApproveInfoResponse : AopResponse
    {
        /// <summary>
        /// 非居民身份证验证名单审核结果查询
        /// </summary>
        [JsonProperty("data")]
        public GetUserWhiteApproveInfoResponseModel Data { get; set; }
        
    }
}