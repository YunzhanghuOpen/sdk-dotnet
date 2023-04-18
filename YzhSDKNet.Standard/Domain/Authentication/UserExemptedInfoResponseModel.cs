using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 上传免验证用户名单信息返回
   /// <summary>
   public class UserExemptedInfoResponseModel : AopObject
   {
      /// <summary>
      /// 是否上传成功
      /// <summary>
      [JsonProperty("ok")]
      public string Ok { get; set; }
   }
}