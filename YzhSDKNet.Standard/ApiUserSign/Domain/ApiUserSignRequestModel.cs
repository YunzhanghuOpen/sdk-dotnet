using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 用户签约请求
    /// </summary>
    public class ApiUserSignRequestModel : AopObject
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
        /// 证件类型 idcard：身份证 passport：护照 mtphkm：港澳居民来往内地通行证 mtpt：台湾居民来往大陆通行证（台胞证） rphkm：中华人民共和国港澳居民居住证 rpt：中华人民共和国台湾居民居住证 fpr：外国人永久居留身份证（外国人永久居留证） fwpa：中华人民共和国外国人工作许可证（A类） fwpb：中华人民共和国外国人工作许可证（B类） fwpc：中华人民共和国外国人工作许可证（C类） mtphkmnc：港澳居民来往内地通行证（非中国国籍）
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

    }
}