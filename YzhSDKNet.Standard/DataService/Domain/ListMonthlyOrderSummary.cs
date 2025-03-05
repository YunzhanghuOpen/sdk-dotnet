using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 月订单汇总数据详情
    /// </summary>
    public class ListMonthlyOrderSummary : AopObject
    {
        /// <summary>
        /// 成功订单汇总
        /// </summary>
        [JsonProperty("success")]
        public MonthlyOrderSummary Success { get; set; }
        
        /// <summary>
        /// 处理中订单汇总
        /// </summary>
        [JsonProperty("processing")]
        public MonthlyOrderSummary Processing { get; set; }
        
        /// <summary>
        /// 失败订单汇总
        /// </summary>
        [JsonProperty("failed")]
        public MonthlyOrderSummary Failed { get; set; }
        
    }
}