using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 用户签约信息上传返回
   /// </summary>
   public class UploadUserSignResponseModel : AopObject
   {
      /// <summary>
      /// 上传状态
      /// </summary>
      [JsonProperty("status")]
      public string Status { get; set; }
      
   }
}