using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 下载个人所得税申报明细表返回
    /// </summary>
    public class GetTaxFileResponseModel : AopObject
    {
        /// <summary>
        /// 文件详情
        /// </summary>
        [JsonProperty("file_info")]
        public FileInfo[] FileInfo { get; set; }

    }
}