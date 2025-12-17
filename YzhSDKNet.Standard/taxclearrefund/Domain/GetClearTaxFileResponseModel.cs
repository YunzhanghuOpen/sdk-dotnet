using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询税费清缴明细文件返回
    /// </summary>
    public class GetClearTaxFileResponseModel : AopObject
    {
        /// <summary>
        /// 下载地址
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        
    }
}