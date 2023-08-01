using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查看免验证用户名单是否存在返回
   /// </summary>
   public class UserWhiteCheckResponseModel : AopObject
   {
      /// <summary>
      /// ok
      /// </summary>
      [JsonProperty("ok")]
      public bool Ok { get; set; }
   }
}