using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询平台企业汇款信息请求
    /// </summary>
    public class GetDealerVARechargeAccountRequestModel : AopObject
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

    }
}