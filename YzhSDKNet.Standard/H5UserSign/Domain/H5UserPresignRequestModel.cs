using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 预申请签约请求
    /// </summary>
    public class H5UserPresignRequestModel : AopObject
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
        /// 证件类型  0：身份证 2：港澳居民来往内地通行证 3：护照 5：台湾居民来往大陆通行证 9：港澳居民居住证 10：台湾居民居住证 11：外国人永久居留身份证（外国人永久居留证） 15：中华人民共和国外国人工作许可证（A类） 16：中华人民共和国外国人工作许可证（B类） 17：中华人民共和国外国人工作许可证（C类） 18：港澳居民来往内地通行证（非中国国籍）
        /// </summary>
        [JsonProperty("certificate_type")]
        public int CertificateType { get; set; }
        
        /// <summary>
        /// 是否收集手机号码 0：不收集（默认） 1：收集手机号码
        /// </summary>
        [JsonProperty("collect_phone_no")]
        public int CollectPhoneNo { get; set; }
        
    }
}