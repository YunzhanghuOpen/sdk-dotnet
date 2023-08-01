using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询可开具发票额度和发票开具信息请求
   /// </summary>
   public class GetInvoiceAmountRequestModel : AopObject
   {
      /// <summary>
      /// 综合服务主体 ID
      /// </summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }

      /// <summary>
      /// 平台企业 ID
      /// </summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
   }
}