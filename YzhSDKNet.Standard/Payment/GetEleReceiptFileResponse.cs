using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询电子回单
    /// </summary>
    public class GetEleReceiptFileResponse : AopResponse
    {
        /// <summary>
        /// 查询电子回单
        /// </summary>
        [JsonProperty("data")]
        public GetEleReceiptFileResponseModel Data { get; set; }
        
    }
}