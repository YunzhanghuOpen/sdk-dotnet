using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 申请解约请求
    /// </summary>
    public class H5UserReleaseApplyRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }
        
        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }
        
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
        /// 主题颜色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
        
        /// <summary>
        /// 回调 URL
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        
        /// <summary>
        /// 跳转 URL
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectURL { get; set; }
        
    }
}