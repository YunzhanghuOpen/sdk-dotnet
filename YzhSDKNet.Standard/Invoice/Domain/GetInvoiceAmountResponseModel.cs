using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询可开具发票额度和发票开具信息返回
    /// </summary>
    public class GetInvoiceAmountResponseModel : AopObject
    {
        /// <summary>
        /// 可开票额度
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 系统支持的开户行及账号
        /// </summary>
        [JsonProperty("bank_name_account")]
        public BankNameAccount[] BankNameAccount { get; set; }

        /// <summary>
        /// 系统支持的货物或应税劳务、服务名称
        /// </summary>
        [JsonProperty("goods_services_name")]
        public GoodsServicesName[] GoodsServicesName { get; set; }

    }
}