using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询税费清缴完成结果
    /// </summary>
    public class GetClearTaxInfoResponse : AopResponse
    {
        /// <summary>
        /// 查询税费清缴完成结果
        /// </summary>
        [JsonProperty("data")]
        public GetClearTaxInfoResponseModel Data { get; set; }
        
    }
}