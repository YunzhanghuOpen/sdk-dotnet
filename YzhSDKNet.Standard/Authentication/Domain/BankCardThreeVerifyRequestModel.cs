using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 银行卡三要素验证请求
    /// </summary>
    public class BankCardThreeVerifyRequestModel : AopObject
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 身份证号码
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