using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询平台企业已开具和待开具发票金额请求
    /// </summary>
    public class GetInvoiceStatRequestModel : AopObject
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
        /// 查询年份
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

    }
}