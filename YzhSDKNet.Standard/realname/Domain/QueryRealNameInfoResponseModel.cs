using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryRealNameInfoResponse
    /// </summary>
    public class QueryRealNameInfoResponseModel : AopObject
    {
        /// <summary>
        /// 实名认证结果
        /// </summary>
        [JsonProperty("realname_result")]
        public int RealnameResult { get; set; }
        
        /// <summary>
        /// 实名认证通过时间
        /// </summary>
        [JsonProperty("realname_time")]
        public string RealnameTime { get; set; }
        
        /// <summary>
        /// 实名认证方式
        /// </summary>
        [JsonProperty("realname_type")]
        public int RealnameType { get; set; }
        
        /// <summary>
        /// 实名认证唯一可追溯编码
        /// </summary>
        [JsonProperty("realname_trace_id")]
        public string RealnameTraceID { get; set; }
        
        /// <summary>
        /// 认证平台
        /// </summary>
        [JsonProperty("realname_platform")]
        public string RealnamePlatform { get; set; }
        
        /// <summary>
        /// 是否存在人脸照片
        /// </summary>
        [JsonProperty("face_image")]
        public string FaceImage { get; set; }
        
        /// <summary>
        /// 人脸识别验证分数
        /// </summary>
        [JsonProperty("face_verify_score")]
        public string FaceVerifyScore { get; set; }
        
        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("bank_no")]
        public string BankNo { get; set; }
        
        /// <summary>
        /// 银行预留手机号
        /// </summary>
        [JsonProperty("bank_phone")]
        public string BankPhone { get; set; }
        
        /// <summary>
        /// 平台企业审核人
        /// </summary>
        [JsonProperty("reviewer")]
        public string Reviewer { get; set; }
        
    }
}