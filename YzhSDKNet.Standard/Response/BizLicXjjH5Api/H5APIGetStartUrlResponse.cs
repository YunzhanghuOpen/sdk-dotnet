using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 预启动
   /// <summary>
   public class H5APIGetStartUrlResponse : AopResponse
   {
      /// <summary>
      /// 预启动
      /// <summary>
      [JsonProperty("data")]
      public H5APIGetStartUrlResponseModel Data { get; set; }
   }
}