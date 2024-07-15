using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 用户签约返回
    /// </summary>
    public class ApiUserSignResponseModel : AopObject
    {
        /// <summary>
        /// 是否签约成功
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

    }
}