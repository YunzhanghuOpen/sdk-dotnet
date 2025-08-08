using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 获取收集手机号码页面请求
    /// </summary>
    public class GetUserCollectPhoneUrlRequestModel : AopObject
    {
        /// <summary>
        /// 手机号码收集 Token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        
        /// <summary>
        /// 主题颜色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
        
        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        
        /// <summary>
        /// 跳转 URL
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectURL { get; set; }
        
    }
}