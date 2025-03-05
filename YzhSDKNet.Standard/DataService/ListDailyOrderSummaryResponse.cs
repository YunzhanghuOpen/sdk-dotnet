using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询日订单汇总数据
    /// </summary>
    public class ListDailyOrderSummaryResponse : AopResponse
    {
        /// <summary>
        /// 查询日订单汇总数据
        /// </summary>
        [JsonProperty("data")]
        public ListDailyOrderSummaryResponseModel Data { get; set; }
        
    }
}