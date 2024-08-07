using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 批次下单返回
    /// </summary>
    public class CreateBatchOrderResponseModel : AopObject
    {
        /// <summary>
        /// 平台企业批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }

        /// <summary>
        /// 订单结果列表
        /// </summary>
        [JsonProperty("result_list")]
        public BatchOrderResult[] ResultList { get; set; }

    }
}