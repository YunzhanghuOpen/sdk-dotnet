using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 月订单汇总详情
    /// </summary>
    public class MonthlyOrderSummary : AopObject
    {
        /// <summary>
        /// 订单数量
        /// </summary>
        [JsonProperty("order_num")]
        public int OrderNum { get; set; }
        
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }
        
        /// <summary>
        /// 加成服务费金额
        /// </summary>
        [JsonProperty("broker_fee")]
        public string BrokerFee { get; set; }
        
        /// <summary>
        /// 加成服务费实收金额
        /// </summary>
        [JsonProperty("broker_real_fee")]
        public string BrokerRealFee { get; set; }
        
        /// <summary>
        /// 已抵扣加成服务费金额
        /// </summary>
        [JsonProperty("broker_rebate_fee")]
        public string BrokerRebateFee { get; set; }
        
        /// <summary>
        /// 用户加成服务费金额
        /// </summary>
        [JsonProperty("user_fee")]
        public string UserFee { get; set; }
        
    }
}