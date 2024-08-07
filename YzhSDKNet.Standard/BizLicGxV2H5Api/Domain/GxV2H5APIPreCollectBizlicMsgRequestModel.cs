using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 工商实名信息录入请求
    /// </summary>
    public class GxV2H5APIPreCollectBizlicMsgRequestModel : AopObject
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
        /// 平台企业端的用户 ID
        /// </summary>
        [JsonProperty("dealer_user_id")]
        public string DealerUserID { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 身份证住址
        /// </summary>
        [JsonProperty("id_card_address")]
        public string IDCardAddress { get; set; }

        /// <summary>
        /// 身份证签发机关
        /// </summary>
        [JsonProperty("id_card_agency")]
        public string IDCardAgency { get; set; }

        /// <summary>
        /// 身份证民族
        /// </summary>
        [JsonProperty("id_card_nation")]
        public string IDCardNation { get; set; }

        /// <summary>
        /// 身份证有效期开始时间
        /// </summary>
        [JsonProperty("id_card_validity_start")]
        public string IDCardValidityStart { get; set; }

        /// <summary>
        /// 身份证有效期结束时间
        /// </summary>
        [JsonProperty("id_card_validity_end")]
        public string IDCardValidityEnd { get; set; }

    }
}