using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 订单税费试算
    /// </summary>
    public class CalcTaxResponse : AopResponse
    {
        /// <summary>
        /// 订单税费试算
        /// </summary>
        [JsonProperty("data")]
        public CalcTaxResponseModel Data { get; set; }
        
    }
}