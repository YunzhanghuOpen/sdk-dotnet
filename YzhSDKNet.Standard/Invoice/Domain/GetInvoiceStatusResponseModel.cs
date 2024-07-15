using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询发票开具申请状态返回
    /// </summary>
    public class GetInvoiceStatusResponseModel : AopObject
    {
        /// <summary>
        /// 申请结果
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 发票张数
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// 价税合计
        /// </summary>
        [JsonProperty("price_tax_amount")]
        public string PriceTaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("price_amount")]
        public string PriceAmount { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [JsonProperty("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonProperty("customer_tax_num")]
        public string CustomerTaxNum { get; set; }

        /// <summary>
        /// 购方地址、电话
        /// </summary>
        [JsonProperty("customer_address_tel")]
        public string CustomerAddressTel { get; set; }

        /// <summary>
        /// 开户行及账号
        /// </summary>
        [JsonProperty("bank_name_account")]
        public string BankNameAccount { get; set; }

        /// <summary>
        /// 货物或应税劳务、服务名称
        /// </summary>
        [JsonProperty("goods_services_name")]
        public string GoodsServicesName { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 邮寄类型
        /// </summary>
        [JsonProperty("post_type")]
        public string PostType { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonProperty("waybill_number")]
        public string[] WaybillNumber { get; set; }

    }
}