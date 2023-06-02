using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 批次确认
   /// <summary>
   public class ConfirmBatchOrderResponse : AopResponse
   {
      /// <summary>
      /// 批次确认
      /// <summary>
      [JsonProperty("data")]
      public ConfirmBatchOrderResponseModel Data { get; set; }
   }
}