using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询手机号码绑定状态
    /// </summary>
    public class GetUserCollectPhoneStatusResponse : AopResponse
    {
        /// <summary>
        /// 查询手机号码绑定状态
        /// </summary>
        [JsonProperty("data")]
        public GetUserCollectPhoneStatusResponseModel Data { get; set; }
        
    }
}