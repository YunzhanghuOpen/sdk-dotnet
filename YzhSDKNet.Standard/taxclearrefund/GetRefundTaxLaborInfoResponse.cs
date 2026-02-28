using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询税费退补涉及劳动者
    /// </summary>
    public class GetRefundTaxLaborInfoResponse : AopResponse
    {
        /// <summary>
        /// 查询税费退补涉及劳动者
        /// </summary>
        [JsonProperty("data")]
        public GetRefundTaxLaborInfoResponseModel Data { get; set; }
        
    }
}