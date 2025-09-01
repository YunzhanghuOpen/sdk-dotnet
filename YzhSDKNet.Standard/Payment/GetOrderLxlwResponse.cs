using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询劳务模式单笔订单信息
    /// </summary>
    public class GetOrderLxlwResponse : AopResponse
    {
        /// <summary>
        /// 查询劳务模式单笔订单信息
        /// </summary>
        [JsonProperty("data")]
        public GetOrderLxlwResponseModel Data { get; set; }
        
    }
}