using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 收集手机号码结果回调通知
    /// </summary>
    public class NotifyUserCollectPhoneRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业用户 ID
        /// </summary>
        [JsonProperty("dealer_user_id")]
        public string DealerUserID { get; set; }
        
        /// <summary>
        /// 手机号码绑定状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        
    }
}