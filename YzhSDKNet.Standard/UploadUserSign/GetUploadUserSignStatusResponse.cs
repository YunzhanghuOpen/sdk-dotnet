using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 获取用户签约状态
    /// </summary>
    public class GetUploadUserSignStatusResponse : AopResponse
    {
        /// <summary>
        /// 获取用户签约状态
        /// </summary>
        [JsonProperty("data")]
        public GetUploadUserSignStatusResponseModel Data { get; set; }
        
    }
}