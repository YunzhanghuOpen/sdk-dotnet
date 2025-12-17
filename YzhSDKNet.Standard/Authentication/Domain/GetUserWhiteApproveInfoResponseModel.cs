using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetUserWhiteApproveInfoResponse
    /// </summary>
    public class GetUserWhiteApproveInfoResponseModel : AopObject
    {
        /// <summary>
        /// 审核状态 pass：通过 reviewing：审核中 reject：拒绝
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// 审核信息
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }
        
    }
}