using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 非居民身份证验证名单审核结果查询请求
    /// </summary>
    public class GetUserWhiteApproveInfoRequestModel : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
        /// <summary>
        /// 证件类型编码
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }
        
    }
}