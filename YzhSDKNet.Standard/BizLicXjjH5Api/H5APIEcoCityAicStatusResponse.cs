using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 查询个体工商户状态
   /// </summary>
   public class H5APIEcoCityAicStatusResponse : AopResponse
   {
      /// <summary>
      /// 查询个体工商户状态
      /// </summary>
      [JsonProperty("data")]
      public H5APIEcoCityAicStatusResponseModel Data { get; set; }
   }
}