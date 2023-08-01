using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 用户解约（测试账号专用接口）返回
   /// </summary>
   public class ApiUserSignReleaseResponseModel : AopObject
   {
      /// <summary>
      /// 是否解约成功
      /// </summary>
      [JsonProperty("status")]
      public string Status { get; set; }
   }
}