using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询日订单汇总数据请求
    /// </summary>
    public class ListDailyOrderSummaryRequestModel : AopObject
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
        /// 支付路径，银行卡、支付宝、微信
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }
        
        /// <summary>
        /// 订单查询开始日期，格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty("begin_at")]
        public string BeginAt { get; set; }
        
        /// <summary>
        /// 订单查询结束日期，格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty("end_at")]
        public string EndAt { get; set; }
        
        /// <summary>
        /// 筛选类型，apply：按订单创建时间汇总 complete：按订单完成时间汇总
        /// </summary>
        [JsonProperty("filter_type")]
        public string FilterType { get; set; }
        
    }
}