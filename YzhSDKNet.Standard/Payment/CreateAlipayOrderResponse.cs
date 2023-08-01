using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 支付宝实时支付
   /// </summary>
   public class CreateAlipayOrderResponse : AopResponse
   {
      /// <summary>
      /// 支付宝实时支付
      /// </summary>
      [JsonProperty("data")]
      public CreateAlipayOrderResponseModel Data { get; set; }
   }
}