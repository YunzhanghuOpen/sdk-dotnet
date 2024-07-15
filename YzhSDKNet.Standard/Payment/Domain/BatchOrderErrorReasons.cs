using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 下单失败原因信息
    /// </summary>
    public class BatchOrderErrorReasons : AopObject
    {
        /// <summary>
        /// 不允许下单原因码
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 不允许下单原因描述
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

    }
}