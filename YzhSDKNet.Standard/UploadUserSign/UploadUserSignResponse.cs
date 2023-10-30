using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 用户签约信息上传
   /// </summary>
   public class UploadUserSignResponse : AopResponse
   {
      /// <summary>
      /// 用户签约信息上传
      /// </summary>
      [JsonProperty("data")]
      public UploadUserSignResponseModel Data { get; set; }
   }
}