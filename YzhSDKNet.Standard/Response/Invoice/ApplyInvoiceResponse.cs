using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 发票开具申请
   /// <summary>
   public class ApplyInvoiceResponse : AopResponse
   {
      /// <summary>
      /// 发票开具申请
      /// <summary>
      [JsonProperty("data")]
      public ApplyInvoiceResponseModel Data { get; set; }
   }
}