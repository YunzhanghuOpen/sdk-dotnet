using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 支付宝实时支付请求
    /// </summary>
    public class CreateAlipayOrderRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }

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
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 支付宝账户
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
        /// 订单金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty("pay_remark")]
        public string PayRemark { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty("notify_url")]
        public string NotifyURL { get; set; }

        /// <summary>
        /// 项目标识
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectID { get; set; }

        /// <summary>
        /// 校验支付宝账户姓名，固定值：Check
        /// </summary>
        [JsonProperty("check_name")]
        public string CheckName { get; set; }

    }
}