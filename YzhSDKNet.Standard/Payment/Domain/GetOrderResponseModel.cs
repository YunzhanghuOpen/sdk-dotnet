using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询单笔订单信息返回
    /// </summary>
    public class GetOrderResponseModel : AopObject
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
        /// 订单详细状态码描述
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
        /// 综合服务主体加成服务费
        /// </summary>
        [JsonProperty("broker_fee")]
        public string BrokerFee { get; set; }

        /// <summary>
        /// 余额账户支出加成服务费
        /// </summary>
        [JsonProperty("broker_real_fee")]
        public string BrokerRealFee { get; set; }

        /// <summary>
        /// 抵扣账户支出加成服务费
        /// </summary>
        [JsonProperty("broker_deduct_fee")]
        public string BrokerDeductFee { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty("pay_remark")]
        public string PayRemark { get; set; }

        /// <summary>
        /// 用户加成服务费
        /// </summary>
        [JsonProperty("user_fee")]
        public string UserFee { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 项目标识
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

    }
}