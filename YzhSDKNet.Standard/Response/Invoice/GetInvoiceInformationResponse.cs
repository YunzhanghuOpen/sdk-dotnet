using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 查询发票信息
   /// <summary>
   public class GetInvoiceInformationResponse : AopResponse
   {
      /// <summary>
      /// 查询发票信息
      /// <summary>
      [JsonProperty("data")]
      public GetInvoiceInformationResponseModel Data { get; set; }
   }
}