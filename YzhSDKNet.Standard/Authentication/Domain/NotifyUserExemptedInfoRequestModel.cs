using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 非居民身份证验证名单审核结果回调通知
    /// </summary>
    public class NotifyUserExemptedInfoRequestModel : AopObject
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
        /// 证件号
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// 审核信息
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

    }
}