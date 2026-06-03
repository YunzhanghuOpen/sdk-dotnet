using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询人脸识别实名核验结果请求
    /// </summary>
    public class GetFaceAuthResultRequestModel : AopObject
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
        /// 人脸识别实名核验唯一 ID
        /// </summary>
        [JsonProperty("record_id")]
        public string RecordID { get; set; }
        
        /// <summary>
        /// 平台企业实名核验 ID
        /// </summary>
        [JsonProperty("verification_id")]
        public string VerificationID { get; set; }
        
    }
}