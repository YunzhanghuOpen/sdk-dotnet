using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询手机号码绑定状态返回
    /// </summary>
    public class GetUserCollectPhoneStatusResponseModel : AopObject
    {
        /// <summary>
        /// 手机号码收集 Token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        
        /// <summary>
        /// 绑定状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        
    }
}