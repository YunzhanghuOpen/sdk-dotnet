using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 日订单汇总数据详情
    /// </summary>
    public class ListDailyOrderSummary : AopObject
    {
        /// <summary>
        /// 订单查询日期，格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }
        
        /// <summary>
        /// 成功订单汇总
        /// </summary>
        [JsonProperty("success")]
        public DailyOrderSummary Success { get; set; }
        
        /// <summary>
        /// 处理中订单汇总
        /// </summary>
        [JsonProperty("processing")]
        public DailyOrderSummary Processing { get; set; }
        
        /// <summary>
        /// 失败订单汇总
        /// </summary>
        [JsonProperty("failed")]
        public DailyOrderSummary Failed { get; set; }
        
    }
}