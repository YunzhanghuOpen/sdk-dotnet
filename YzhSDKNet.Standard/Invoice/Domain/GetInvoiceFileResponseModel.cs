using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 下载 PDF 版发票返回
    /// </summary>
    public class GetInvoiceFileResponseModel : AopObject
    {
        /// <summary>
        /// 下载地址
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}