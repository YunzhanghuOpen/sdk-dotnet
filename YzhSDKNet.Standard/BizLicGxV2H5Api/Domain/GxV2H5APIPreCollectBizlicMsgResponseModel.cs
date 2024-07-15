using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 工商实名信息录入返回
    /// </summary>
    public class GxV2H5APIPreCollectBizlicMsgResponseModel : AopObject
    {
        /// <summary>
        /// 平台企业端的用户 ID
        /// </summary>
        [JsonProperty("dealer_user_id")]
        public string DealerUserID { get; set; }

    }
}