using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 人脸识别实名核验失败详情
    /// </summary>
    public class FaceAuthDetail : AopObject
    {
        /// <summary>
        /// 实名核验失败原因
        /// </summary>
        [JsonProperty("fail_reason")]
        public string FailReason { get; set; }
        
    }
}