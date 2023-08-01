using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 银行卡四要素确认请求（上传短信验证码）
   /// </summary>
   public class BankCardFourAuthConfirmResponse : AopResponse
   {
      /// <summary>
      /// 银行卡四要素确认请求（上传短信验证码）
      /// </summary>
      [JsonProperty("data")]
      public BankCardFourAuthConfirmResponseModel Data { get; set; }
   }
}