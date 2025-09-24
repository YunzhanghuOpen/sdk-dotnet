using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询批次订单信息订单详情
    /// </summary>
    public class QueryBatchOrderInfo : AopObject
    {
        /// <summary>
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }
        
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }
        
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
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        
        /// <summary>
        /// 收款人账号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
        
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone_no")]
        public string PhoneNo { get; set; }
        
        /// <summary>
        /// 订单状态码
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// 订单详情状态码
        /// </summary>
        [JsonProperty("status_detail")]
        public string StatusDetail { get; set; }
        
        /// <summary>
        /// 订单状态码描述
        /// </summary>
        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }
        
        /// <summary>
        /// 订单详情状态码描述
        /// </summary>
        [JsonProperty("status_detail_message")]
        public string StatusDetailMessage { get; set; }
        
        /// <summary>
        /// 订单状态补充信息
        /// </summary>
        [JsonProperty("supplemental_detail_message")]
        public string SupplementalDetailMessage { get; set; }
        
        /// <summary>
        /// 综合服务主体支付金额
        /// </summary>
        [JsonProperty("broker_amount")]
        public string BrokerAmount { get; set; }
        
        /// <summary>
        /// 综合服务平台流水号
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }
        
        /// <summary>
        /// 支付交易流水号
        /// </summary>
        [JsonProperty("broker_bank_bill")]
        public string BrokerBankBill { get; set; }
        
        /// <summary>
        /// 支付路径
        /// </summary>
        [JsonProperty("withdraw_platform")]
        public string WithdrawPlatform { get; set; }
        
        /// <summary>
        /// 订单接收时间
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        
        /// <summary>
        /// 订单完成时间
        /// </summary>
        [JsonProperty("finished_time")]
        public string FinishedTime { get; set; }
        
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
        [JsonProperty("broker_deduct_fee")]
        public string BrokerDeductFee { get; set; }
        
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
        /// 订单备注
        /// </summary>
        [JsonProperty("pay_remark")]
        public string PayRemark { get; set; }
        
        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }
        
        /// <summary>
        /// 业务线标识
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectID { get; set; }
        
        /// <summary>
        /// 互联网平台名称
        /// </summary>
        [JsonProperty("dealer_platform_name")]
        public string DealerPlatformName { get; set; }
        
        /// <summary>
        /// 用户名称/昵称
        /// </summary>
        [JsonProperty("dealer_user_nickname")]
        public string DealerUserNickname { get; set; }
        
        /// <summary>
        /// 用户唯一标识码
        /// </summary>
        [JsonProperty("dealer_user_id")]
        public string DealerUserID { get; set; }
        
        /// <summary>
        /// 预扣个税税率
        /// </summary>
        [JsonProperty("personal_tax_rate")]
        public string PersonalTaxRate { get; set; }
        
        /// <summary>
        /// 预扣个税速算扣除数
        /// </summary>
        [JsonProperty("deduct_tax")]
        public string DeductTax { get; set; }
        
    }
}