using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询劳务模式单笔订单信息返回
    /// </summary>
    public class GetOrderLxlwResponseModel : AopObject
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
        /// 订单详细状态码
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
        /// 订单接收时间，精确到秒
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        
        /// <summary>
        /// 订单完成时间，精确到秒
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
        /// 新就业形态劳动者 ID，该字段已废弃
        /// </summary>
        [JsonProperty("anchor_id")]
        public string AnchorID { get; set; }
        
        /// <summary>
        /// 描述信息，该字段已废弃
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }
        
        /// <summary>
        /// 系统支付金额，该字段已废弃
        /// </summary>
        [JsonProperty("sys_amount")]
        public string SysAmount { get; set; }
        
        /// <summary>
        /// 税费，该字段已废弃
        /// </summary>
        [JsonProperty("tax")]
        public string Tax { get; set; }
        
        /// <summary>
        /// 系统支付费用，该字段已废弃
        /// </summary>
        [JsonProperty("sys_fee")]
        public string SysFee { get; set; }
        
        /// <summary>
        /// 用户实收金额
        /// </summary>
        [JsonProperty("user_real_amount")]
        public string UserRealAmount { get; set; }
        
        /// <summary>
        /// 缴税明细
        /// </summary>
        [JsonProperty("tax_detail")]
        public TaxDetail TaxDetail { get; set; }
        
        /// <summary>
        /// 实缴税费总额
        /// </summary>
        [JsonProperty("received_tax_amount")]
        public string ReceivedTaxAmount { get; set; }
        
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
        /// 用户实收金额（追缴前）
        /// </summary>
        [JsonProperty("user_real_excluding_vat_amount")]
        public string UserRealExcludingVatAmount { get; set; }
        
        /// <summary>
        /// 已追缴增附税（本笔订单）
        /// </summary>
        [JsonProperty("user_recover_tax_amount")]
        public string UserRecoverTaxAmount { get; set; }
        
    }
}