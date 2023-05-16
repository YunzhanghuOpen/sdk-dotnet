using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询发票信息返回
   /// <summary>
   public class GetInvoiceInformationResponseModel : AopObject
   {
      /// <summary>
      /// 发票信息
      /// <summary>
      [JsonProperty("information")]
      public InformationDataInfo[] Information { get; set; }
   }
}