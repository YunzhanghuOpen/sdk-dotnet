using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询批次订单信息请求
    /// </summary>
    public class QueryBatchOrderRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }

        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }

    }
}