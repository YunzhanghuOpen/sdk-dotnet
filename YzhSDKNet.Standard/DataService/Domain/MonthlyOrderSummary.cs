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
        
        /// <summary>
        /// 预扣税费总额
        /// </summary>
        [JsonProperty("tax")]
        public string Tax { get; set; }
        
        /// <summary>
        /// 实缴税费总额
        /// </summary>
        [JsonProperty("received_tax_amount")]
        public string ReceivedTaxAmount { get; set; }
        
        /// <summary>
        /// 预扣个税
        /// </summary>
        [JsonProperty("personal_tax")]
        public string PersonalTax { get; set; }
        
        /// <summary>
        /// 预扣增值税
        /// </summary>
        [JsonProperty("value_added_tax")]
        public string ValueAddedTax { get; set; }
        
        /// <summary>
        /// 预扣附加税费
        /// </summary>
        [JsonProperty("additional_tax")]
        public string AdditionalTax { get; set; }
        
        /// <summary>
        /// 实缴个税
        /// </summary>
        [JsonProperty("received_personal_tax")]
        public string ReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 实缴增值税
        /// </summary>
        [JsonProperty("received_value_added_tax")]
        public string ReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 实缴附加税费
        /// </summary>
        [JsonProperty("received_additional_tax")]
        public string ReceivedAdditionalTax { get; set; }
        
        /// <summary>
        /// 用户预扣个税
        /// </summary>
        [JsonProperty("user_personal_tax")]
        public string UserPersonalTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣个税
        /// </summary>
        [JsonProperty("dealer_personal_tax")]
        public string DealerPersonalTax { get; set; }
        
        /// <summary>
        /// 用户预扣增值税
        /// </summary>
        [JsonProperty("user_value_added_tax")]
        public string UserValueAddedTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣增值税
        /// </summary>
        [JsonProperty("dealer_value_added_tax")]
        public string DealerValueAddedTax { get; set; }
        
        /// <summary>
        /// 用户预扣附加税费
        /// </summary>
        [JsonProperty("user_additional_tax")]
        public string UserAdditionalTax { get; set; }
        
        /// <summary>
        /// 平台企业预扣附加税费
        /// </summary>
        [JsonProperty("dealer_additional_tax")]
        public string DealerAdditionalTax { get; set; }
        
        /// <summary>
        /// 用户实缴个税
        /// </summary>
        [JsonProperty("user_received_personal_tax")]
        public string UserReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴个税
        /// </summary>
        [JsonProperty("dealer_received_personal_tax")]
        public string DealerReceivedPersonalTax { get; set; }
        
        /// <summary>
        /// 用户实缴增值税
        /// </summary>
        [JsonProperty("user_received_value_added_tax")]
        public string UserReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴增值税
        /// </summary>
        [JsonProperty("dealer_received_value_added_tax")]
        public string DealerReceivedValueAddedTax { get; set; }
        
        /// <summary>
        /// 用户实缴附加税费
        /// </summary>
        [JsonProperty("user_received_additional_tax")]
        public string UserReceivedAdditionalTax { get; set; }
        
        /// <summary>
        /// 平台企业实缴附加税费
        /// </summary>
        [JsonProperty("dealer_received_additional_tax")]
        public string DealerReceivedAdditionalTax { get; set; }
        
    }
}