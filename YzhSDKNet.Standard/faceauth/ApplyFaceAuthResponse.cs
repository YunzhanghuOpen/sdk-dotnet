using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 申请人脸识别实名核验
    /// </summary>
    public class ApplyFaceAuthResponse : AopResponse
    {
        /// <summary>
        /// 申请人脸识别实名核验
        /// </summary>
        [JsonProperty("data")]
        public ApplyFaceAuthResponseModel Data { get; set; }
        
    }
}