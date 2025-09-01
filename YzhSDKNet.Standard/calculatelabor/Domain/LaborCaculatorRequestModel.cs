using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 连续劳务税费试算（计算器）请求
    /// </summary>
    public class LaborCaculatorRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }
        
        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }
        
        /// <summary>
        /// 月度收入列表
        /// </summary>
        [JsonProperty("month_settlement_list")]
        public MonthSettlement[] MonthSettlementList { get; set; }
        
    }
}