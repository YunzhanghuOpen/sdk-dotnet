using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 查看免验证用户名单是否存在
   /// </summary>
   public class UserWhiteCheckResponse : AopResponse
   {
      /// <summary>
      /// 查看免验证用户名单是否存在
      /// </summary>
      [JsonProperty("data")]
      public UserWhiteCheckResponseModel Data { get; set; }
   }
}