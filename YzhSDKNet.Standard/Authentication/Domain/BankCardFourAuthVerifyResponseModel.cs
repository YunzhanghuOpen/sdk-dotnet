using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 银行卡四要素鉴权请求（下发短信验证码）返回
   /// </summary>
   public class BankCardFourAuthVerifyResponseModel : AopObject
   {
      /// <summary>
      /// 交易凭证
      /// </summary>
      [JsonProperty("ref")]
      public string Ref { get; set; }
   }
}