using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 签约回调
    /// </summary>
    public class NotifyH5UserSignRequestModel : AopObject
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
        /// 预签约手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

    }
}