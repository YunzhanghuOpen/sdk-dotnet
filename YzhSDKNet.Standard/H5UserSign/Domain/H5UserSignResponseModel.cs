using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 申请签约返回
    /// </summary>
    public class H5UserSignResponseModel : AopObject
    {
        /// <summary>
        /// H5 签约页面 URL
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }

    }
}