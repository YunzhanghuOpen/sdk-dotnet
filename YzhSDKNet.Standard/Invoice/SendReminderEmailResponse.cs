using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 发送发票扫描件压缩包下载链接邮件
    /// </summary>
    public class SendReminderEmailResponse : AopResponse
    {
        /// <summary>
        /// 发送发票扫描件压缩包下载链接邮件
        /// </summary>
        [JsonProperty("data")]
        public SendReminderEmailResponseModel Data { get; set; }
        
    }
}