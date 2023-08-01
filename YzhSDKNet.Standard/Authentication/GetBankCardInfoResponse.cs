using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 银行卡信息查询接口
   /// </summary>
   public class GetBankCardInfoResponse : AopResponse
   {
      /// <summary>
      /// 银行卡信息查询接口
      /// </summary>
      [JsonProperty("data")]
      public GetBankCardInfoResponseModel Data { get; set; }
   }
}