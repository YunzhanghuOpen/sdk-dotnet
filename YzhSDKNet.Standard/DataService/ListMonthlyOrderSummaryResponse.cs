using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询月订单汇总数据
    /// </summary>
    public class ListMonthlyOrderSummaryResponse : AopResponse
    {
        /// <summary>
        /// 查询月订单汇总数据
        /// </summary>
        [JsonProperty("data")]
        public ListMonthlyOrderSummaryResponseModel Data { get; set; }
        
    }
}