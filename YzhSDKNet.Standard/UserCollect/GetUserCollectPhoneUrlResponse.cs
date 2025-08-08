using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 获取收集手机号码页面
    /// </summary>
    public class GetUserCollectPhoneUrlResponse : AopResponse
    {
        /// <summary>
        /// 获取收集手机号码页面
        /// </summary>
        [JsonProperty("data")]
        public GetUserCollectPhoneUrlResponseModel Data { get; set; }
        
    }
}