using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 用户结算金额校验请求
    /// </summary>
    public class CheckUserAmountRequestModel : AopObject
    {
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
        /// 身份证号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }
        
        /// <summary>
        /// 校验金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }
        
    }
}