using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 预申请签约
   /// <summary>
   public class H5UserPresignResponse : AopResponse
   {
      /// <summary>
      /// 预申请签约
      /// <summary>
      [JsonProperty("data")]
      public H5UserPresignResponseModel Data { get; set; }
   }
}