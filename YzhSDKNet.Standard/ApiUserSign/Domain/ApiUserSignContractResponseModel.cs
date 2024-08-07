using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 获取协议预览 URL 返回 V2
    /// </summary>
    public class ApiUserSignContractResponseModel : AopObject
    {
        /// <summary>
        /// 预览跳转 URL
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}