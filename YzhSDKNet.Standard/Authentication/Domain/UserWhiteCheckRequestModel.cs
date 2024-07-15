using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查看免验证用户名单是否存在请求
    /// </summary>
    public class UserWhiteCheckRequestModel : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }

    }
}