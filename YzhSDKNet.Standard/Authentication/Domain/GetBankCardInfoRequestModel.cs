using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 银行卡信息查询请求
    /// </summary>
    public class GetBankCardInfoRequestModel : AopObject
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

    }
}