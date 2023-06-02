using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 取消待支付订单
   /// <summary>
   public class CancelOrderResponse : AopResponse
   {
      /// <summary>
      /// 取消待支付订单
      /// <summary>
      [JsonProperty("data")]
      public CancelOrderResponseModel Data { get; set; }
   }
}