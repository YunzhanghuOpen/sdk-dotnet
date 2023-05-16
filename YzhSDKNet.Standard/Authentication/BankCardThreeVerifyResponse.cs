using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 银行卡三要素验证
   /// <summary>
   public class BankCardThreeVerifyResponse : AopResponse
   {
      /// <summary>
      /// 银行卡三要素验证
      /// <summary>
      [JsonProperty("data")]
      public BankCardThreeVerifyResponseModel Data { get; set; }
   }
}