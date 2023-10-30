using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 批次撤销
   /// </summary>
   public class CancelBatchOrderResponse : AopResponse
   {
      /// <summary>
      /// 批次撤销
      /// </summary>
      [JsonProperty("data")]
      public CancelBatchOrderResponseModel Data { get; set; }
   }
}