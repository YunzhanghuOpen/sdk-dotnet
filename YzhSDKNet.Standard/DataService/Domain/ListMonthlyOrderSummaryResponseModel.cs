using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询月订单汇总数据返回
    /// </summary>
    public class ListMonthlyOrderSummaryResponseModel : AopObject
    {
        /// <summary>
        /// 汇总数据列表
        /// </summary>
        [JsonProperty("summary")]
        public ListMonthlyOrderSummary Summary { get; set; }
        
    }
}