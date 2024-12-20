using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 发票开具申请请求
    /// </summary>
    public class ApplyInvoiceRequestModel : AopObject
    {
        /// <summary>
        /// 发票申请编号
        /// </summary>
        [JsonProperty("invoice_apply_id")]
        public string InvoiceApplyID { get; set; }

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
        /// 申请开票金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [JsonProperty("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 开户行及账号
        /// </summary>
        [JsonProperty("bank_name_account")]
        public string BankNameAccount { get; set; }

        /// <summary>
        /// 货物或应税劳务、服务名称
        /// </summary>
        [JsonProperty("goods_services_name")]
        public string GoodsServicesName { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发票接收邮箱
        /// </summary>
        [JsonProperty("receive_emails")]
        public string[] ReceiveEmails { get; set; }

        /// <summary>
        /// 发票介质
        /// </summary>
        [JsonProperty("invoice_media")]
        public string InvoiceMedia { get; set; }

    }
}