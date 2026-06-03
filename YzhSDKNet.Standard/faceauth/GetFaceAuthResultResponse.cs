using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询人脸识别实名核验结果
    /// </summary>
    public class GetFaceAuthResultResponse : AopResponse
    {
        /// <summary>
        /// 查询人脸识别实名核验结果
        /// </summary>
        [JsonProperty("data")]
        public GetFaceAuthResultResponseModel Data { get; set; }
        
    }
}