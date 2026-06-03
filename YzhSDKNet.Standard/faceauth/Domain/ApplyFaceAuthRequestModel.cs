using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 申请人脸识别实名核验请求
    /// </summary>
    public class ApplyFaceAuthRequestModel : AopObject
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
        /// 平台企业实名核验 ID
        /// </summary>
        [JsonProperty("verification_id")]
        public string VerificationID { get; set; }
        
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
        /// 回调地址
        /// </summary>
        [JsonProperty("callback_url")]
        public string CallbackURL { get; set; }
        
        /// <summary>
        /// 跳转 URL
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectURL { get; set; }
        
        /// <summary>
        /// 主题颜色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
        
    }
}