using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询税费退补完成结果
    /// </summary>
    public class GetRefundTaxInfoResponse : AopResponse
    {
        /// <summary>
        /// 查询税费退补完成结果
        /// </summary>
        [JsonProperty("data")]
        public RefundTaxData Data { get; set; }

    }
}