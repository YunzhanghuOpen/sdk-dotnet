using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询月订单汇总数据请求
    /// </summary>
    public class ListMonthlyOrderSummaryRequestModel : AopObject
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
        /// 汇总月份，格式：yyyy-MM
        /// </summary>
        [JsonProperty("month")]
        public string Month { get; set; }
        
        /// <summary>
        /// 筛选类型，apply：按订单创建时间汇总 complete：按订单完成时间汇总
        /// </summary>
        [JsonProperty("filter_type")]
        public string FilterType { get; set; }
        
    }
}