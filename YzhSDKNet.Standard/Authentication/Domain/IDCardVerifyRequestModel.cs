using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 身份证实名验证请求
   /// <summary>
   public class IDCardVerifyRequestModel : AopObject
   {
      /// <summary>
      /// 身份证号码
      /// <summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }

      /// <summary>
      /// 姓名
      /// <summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }
   }
}