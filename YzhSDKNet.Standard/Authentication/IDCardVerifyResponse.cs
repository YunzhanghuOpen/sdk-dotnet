using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 身份证实名验证
    /// </summary>
    public class IDCardVerifyResponse : AopResponse
    {
        /// <summary>
        /// 身份证实名验证
        /// </summary>
        [JsonProperty("data")]
        public IDCardVerifyResponseModel Data { get; set; }
        
    }
}