using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 日订单汇总详情
    /// </summary>
    public class DailyOrderSummary : AopObject
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
        /// 应收综合服务主体加成服务费金额
        /// </summary>
        [JsonProperty("broker_fee")]
        public string BrokerFee { get; set; }
        
        /// <summary>
        /// 应收余额账户支出加成服务费金额
        /// </summary>
        [JsonProperty("broker_real_fee")]
        public string BrokerRealFee { get; set; }
        
        /// <summary>
        /// 应收加成服务费抵扣金额
        /// </summary>
        [JsonProperty("broker_rebate_fee")]
        public string BrokerRebateFee { get; set; }
        
        /// <summary>
        /// 应收用户加成服务费金额
        /// </summary>
        [JsonProperty("user_fee")]
        public string UserFee { get; set; }
        
        /// <summary>
        /// 实收综合服务主体加成服务费金额
        /// </summary>
        [JsonProperty("received_broker_fee")]
        public string ReceivedBrokerFee { get; set; }
        
        /// <summary>
        /// 实收余额账户支出加成服务费金额
        /// </summary>
        [JsonProperty("received_broker_real_fee")]
        public string ReceivedBrokerRealFee { get; set; }
        
        /// <summary>
        /// 实收加成服务费抵扣金额
        /// </summary>
        [JsonProperty("received_broker_deduct_fee")]
        public string ReceivedBrokerDeductFee { get; set; }
        
        /// <summary>
        /// 实收用户加成服务费金额
        /// </summary>
        [JsonProperty("received_user_fee")]
        public string ReceivedUserFee { get; set; }
        
    }
}