using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 用户解约返回
    /// </summary>
    public class ApiUserSignReleaseResponseModel : AopObject
    {
        /// <summary>
        /// 是否解约成功
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
    }
}