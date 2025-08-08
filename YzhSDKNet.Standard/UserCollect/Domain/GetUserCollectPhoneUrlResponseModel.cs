using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 获取收集手机号码页面返回
    /// </summary>
    public class GetUserCollectPhoneUrlResponseModel : AopObject
    {
        /// <summary>
        /// 收集手机号码页面 URL
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        
    }
}