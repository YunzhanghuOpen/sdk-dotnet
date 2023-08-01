using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 下载个人所得税扣缴明细表
   /// </summary>
   public class GetTaxFileResponse : AopResponse
   {
      /// <summary>
      /// 下载个人所得税扣缴明细表
      /// </summary>
      [JsonProperty("data")]
      public GetTaxFileResponseModel Data { get; set; }
   }
}