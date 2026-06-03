using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询人脸识别实名核验结果返回
    /// </summary>
    public class GetFaceAuthResultResponseModel : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
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
        /// 实名核验状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// 实名核验完成时间
        /// </summary>
        [JsonProperty("verify_time")]
        public string VerifyTime { get; set; }
        
        /// <summary>
        /// 实名核验失败详情
        /// </summary>
        [JsonProperty("detail")]
        public FaceAuthDetail Detail { get; set; }
        
    }
}