using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询手机号码绑定状态请求
    /// </summary>
    public class GetUserCollectPhoneStatusRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }
        
        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }
        
        /// <summary>
        /// 平台企业用户 ID
        /// </summary>
        [JsonProperty("dealer_user_id")]
        public string DealerUserID { get; set; }
        
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
        /// 证件类型编码
        /// </summary>
        [JsonProperty("certificate_type")]
        public int CertificateType { get; set; }
        
    }
}