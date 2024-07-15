using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询电子回单返回
    /// </summary>
    public class GetEleReceiptFileResponseModel : AopObject
    {
        /// <summary>
        /// 链接失效时间
        /// </summary>
        [JsonProperty("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 回单名
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 下载链接
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }

    }
}