using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询日订单汇总数据返回
    /// </summary>
    public class ListDailyOrderSummaryResponseModel : AopObject
    {
        /// <summary>
        /// 汇总数据列表
        /// </summary>
        [JsonProperty("summary_list")]
        public ListDailyOrderSummary[] SummaryList { get; set; }
        
    }
}