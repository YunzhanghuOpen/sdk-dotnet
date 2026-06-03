using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 申请解约返回
    /// </summary>
    public class H5UserReleaseApplyResponseModel : AopObject
    {
        /// <summary>
        /// 签约状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        
        /// <summary>
        /// H5 解约页面 URL
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        
    }
}