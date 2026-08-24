using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 申请签约请求
    /// </summary>
    public class H5UserSignRequestModel : AopObject
    {
        /// <summary>
        /// 签约 token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// 主题颜色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// 签约完成回调地址
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }

        /// <summary>
        /// 签约事件状态回调地址
        /// </summary>
        [JsonProperty("event_callback_url")]
        public string EventCallbackURL { get; set; }

        /// <summary>
        /// 跳转 URL
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectURL { get; set; }

    }
}