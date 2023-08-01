using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 发票开具申请返回
   /// </summary>
   public class ApplyInvoiceResponseModel : AopObject
   {
      /// <summary>
      /// 发票申请单 ID
      /// </summary>
      [JsonProperty("application_id")]
      public string ApplicationID { get; set; }

      /// <summary>
      /// 发票张数
      /// </summary>
      [JsonProperty("count")]
      public long Count { get; set; }
   }
}