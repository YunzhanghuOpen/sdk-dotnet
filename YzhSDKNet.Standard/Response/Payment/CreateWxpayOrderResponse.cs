using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 微信实时支付
   /// <summary>
   public class CreateWxpayOrderResponse : AopResponse
   {
      /// <summary>
      /// 微信实时支付
      /// <summary>
      [JsonProperty("data")]
      public CreateWxpayOrderResponseModel Data { get; set; }
   }
}