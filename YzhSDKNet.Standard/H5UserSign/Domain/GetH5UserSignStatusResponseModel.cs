using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 获取用户签约状态返回
    /// </summary>
    public class GetH5UserSignStatusResponseModel : AopObject
    {
        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonProperty("signed_at")]
        public string SignedAt { get; set; }

        /// <summary>
        /// 用户签约状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

    }
}