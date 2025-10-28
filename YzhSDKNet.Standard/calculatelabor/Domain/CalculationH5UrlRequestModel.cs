using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 连续劳务单笔结算税费测算-H5 请求
    /// </summary>
    public class CalculationH5UrlRequestModel : AopObject
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
        /// 证件号
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
        /// <summary>
        /// 主题颜色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
        
        /// <summary>
        /// 是否隐藏导航栏 0：展示导航栏（默认） 1：隐藏导航栏
        /// </summary>
        [JsonProperty("navbar_hide")]
        public int NavbarHide { get; set; }

        /// <summary>
        /// 页面标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}