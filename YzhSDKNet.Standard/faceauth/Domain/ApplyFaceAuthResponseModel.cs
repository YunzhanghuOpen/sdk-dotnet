using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 申请人脸识别实名核验返回
    /// </summary>
    public class ApplyFaceAuthResponseModel : AopObject
    {
        /// <summary>
        /// 人脸识别实名核验唯一 ID
        /// </summary>
        [JsonProperty("record_id")]
        public string RecordID { get; set; }
        
        /// <summary>
        /// 平台企业实名核验 ID
        /// </summary>
        [JsonProperty("verification_id")]
        public string VerificationID { get; set; }
        
        /// <summary>
        /// 人脸识别实名核验 H5 页面地址
        /// </summary>
        [JsonProperty("verification_url")]
        public string VerificationURL { get; set; }
        
    }
}