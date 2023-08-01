using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询平台企业已开具和待开具发票金额返回
   /// </summary>
   public class GetInvoiceStatResponseModel : AopObject
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
      /// 已开发票金额
      /// </summary>
      [JsonProperty("invoiced")]
      public string Invoiced { get; set; }

      /// <summary>
      /// 开票中发票金额
      /// </summary>
      [JsonProperty("invoicing")]
      public string Invoicing { get; set; }

      /// <summary>
      /// 待开发票金额
      /// </summary>
      [JsonProperty("not_invoiced")]
      public string NotInvoiced { get; set; }
   }
}