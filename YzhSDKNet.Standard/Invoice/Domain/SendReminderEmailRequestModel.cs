using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 发送发票开具成功通知邮件请求
    /// </summary>
    public class SendReminderEmailRequestModel : AopObject
    {
        /// <summary>
        /// 发票申请编号
        /// </summary>
        [JsonProperty("invoice_apply_id")]
        public string InvoiceApplyID { get; set; }

        /// <summary>
        /// 发票申请单 ID
        /// </summary>
        [JsonProperty("application_id")]
        public string ApplicationID { get; set; }

    }
}