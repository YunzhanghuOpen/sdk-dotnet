using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 工商实名信息录入
   /// </summary>
   public class GxV2H5APIPreCollectBizlicMsgResponse : AopResponse
   {
      /// <summary>
      /// 工商实名信息录入
      /// </summary>
      [JsonProperty("data")]
      public GxV2H5APIPreCollectBizlicMsgResponseModel Data { get; set; }
   }
}