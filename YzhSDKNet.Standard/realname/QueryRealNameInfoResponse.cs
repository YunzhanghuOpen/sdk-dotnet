using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 用户实名认证信息查询
    /// </summary>
    public class QueryRealNameInfoResponse : AopResponse
    {
        /// <summary>
        /// 用户实名认证信息查询
        /// </summary>
        [JsonProperty("data")]
        public QueryRealNameInfoResponseModel Data { get; set; }
        
    }
}