using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 申请解约
    /// </summary>
    public class H5UserReleaseApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请解约
        /// </summary>
        [JsonProperty("data")]
        public H5UserReleaseApplyResponseModel Data { get; set; }
        
    }
}