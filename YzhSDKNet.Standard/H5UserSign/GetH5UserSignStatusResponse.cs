using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 获取用户签约状态
   /// </summary>
   public class GetH5UserSignStatusResponse : AopResponse
   {
      /// <summary>
      /// 获取用户签约状态
      /// </summary>
      [JsonProperty("data")]
      public GetH5UserSignStatusResponseModel Data { get; set; }
   }
}