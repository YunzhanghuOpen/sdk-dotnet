using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 下载 PDF 版发票
   /// <summary>
   public class GetInvoiceFileResponse : AopResponse
   {
      /// <summary>
      /// 下载 PDF 版发票
      /// <summary>
      [JsonProperty("data")]
      public GetInvoiceFileResponseModel Data { get; set; }
   }
}