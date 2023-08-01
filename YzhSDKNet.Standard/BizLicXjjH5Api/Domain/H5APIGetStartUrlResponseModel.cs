using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 预启动返回
   /// </summary>
   public class H5APIGetStartUrlResponseModel : AopObject
   {
      /// <summary>
      /// 跳转 URL
      /// </summary>
      [JsonProperty("h5_url")]
      public string H5URL { get; set; }
   }
}