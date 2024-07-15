using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询个体工商户状态
    /// </summary>
    public class GxV2H5APIGetAicStatusResponse : AopResponse
    {
        /// <summary>
        /// 查询个体工商户状态
        /// </summary>
        [JsonProperty("data")]
        public GxV2H5APIGetAicStatusResponseModel Data { get; set; }
        
    }
}