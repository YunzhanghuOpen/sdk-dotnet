using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectRealNameInfoRequest
    /// </summary>
    public class CollectRealNameInfoRequestModel : AopObject
    {
        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }
        
        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }
        
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
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
        /// 人脸照片
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
        
        /// <summary>
        /// 人脸照片收集类型
        /// </summary>
        [JsonProperty("face_image_collect_type")]
        public int FaceImageCollectType { get; set; }
        
    }
}