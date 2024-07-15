using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询发票开具申请状态
    /// </summary>
    public class GetInvoiceStatusResponse : AopResponse
    {
        /// <summary>
        /// 查询发票开具申请状态
        /// </summary>
        [JsonProperty("data")]
        public GetInvoiceStatusResponseModel Data { get; set; }
        
    }
}