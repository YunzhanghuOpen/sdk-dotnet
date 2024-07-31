using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// 用户结算金额校验
    /// </summary>
    public class CheckUserAmountResponse : AopResponse
    {
        /// <summary>
        /// 用户结算金额校验
        /// </summary>
        [JsonProperty("data")]
        public CheckUserAmountResponseModel Data { get; set; }
        
    }
}