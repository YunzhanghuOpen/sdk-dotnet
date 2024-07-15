using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 流水详情
    /// </summary>
    public class DealerBillInfo : AopObject
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
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }

        /// <summary>
        /// 资金流水号
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// 综合服务主体名称
        /// </summary>
        [JsonProperty("broker_product_name")]
        public string BrokerProductName { get; set; }

        /// <summary>
        /// 平台企业名称
        /// </summary>
        [JsonProperty("dealer_product_name")]
        public string DealerProductName { get; set; }

        /// <summary>
        /// 业务订单流水号
        /// </summary>
        [JsonProperty("biz_ref")]
        public string BizRef { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        [JsonProperty("acct_type")]
        public string AcctType { get; set; }

        /// <summary>
        /// 入账金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 业务分类
        /// </summary>
        [JsonProperty("business_category")]
        public string BusinessCategory { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 收支类型
        /// </summary>
        [JsonProperty("consumption_type")]
        public string ConsumptionType { get; set; }

        /// <summary>
        /// 入账时间
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

    }
}