using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询税费清缴明细文件
    /// </summary>
    public class GetClearTaxFileResponse : AopResponse
    {
        /// <summary>
        /// 查询税费清缴明细文件
        /// </summary>
        [JsonProperty("data")]
        public GetClearTaxFileResponseModel Data { get; set; }
        
    }
}