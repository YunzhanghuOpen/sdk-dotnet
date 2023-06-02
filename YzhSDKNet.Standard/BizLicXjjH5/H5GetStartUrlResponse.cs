using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 预启动
   /// <summary>
   public class H5GetStartUrlResponse : AopResponse
   {
      /// <summary>
      /// 预启动
      /// <summary>
      [JsonProperty("data")]
      public H5GetStartUrlResponseModel Data { get; set; }
   }
}