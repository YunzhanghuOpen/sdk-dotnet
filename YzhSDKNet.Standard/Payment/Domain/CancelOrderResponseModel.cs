using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 取消待支付订单返回
    /// </summary>
    public class CancelOrderResponseModel : AopObject
    {
        /// <summary>
        /// ok
        /// </summary>
        [JsonProperty("ok")]
        public string Ok { get; set; }

    }
}