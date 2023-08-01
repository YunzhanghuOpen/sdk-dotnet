using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 银行卡四要素鉴权请求（下发短信验证码）
   /// </summary>
   public class BankCardFourAuthVerifyResponse : AopResponse
   {
      /// <summary>
      /// 银行卡四要素鉴权请求（下发短信验证码）
      /// </summary>
      [JsonProperty("data")]
      public BankCardFourAuthVerifyResponseModel Data { get; set; }
   }
}