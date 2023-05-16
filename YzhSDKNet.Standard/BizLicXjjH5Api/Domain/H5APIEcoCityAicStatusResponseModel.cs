using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询个体工商户状态返回
   /// <summary>
   public class H5APIEcoCityAicStatusResponseModel : AopObject
   {
      /// <summary>
      /// 用户签约状态
      /// <summary>
      [JsonProperty("status")]
      public int Status { get; set; }

      /// <summary>
      /// 注册状态描述
      /// <summary>
      [JsonProperty("status_message")]
      public string StatusMessage { get; set; }

      /// <summary>
      /// 注册详情状态码
      /// <summary>
      [JsonProperty("status_detail")]
      public int StatusDetail { get; set; }

      /// <summary>
      /// 注册详情状态码描述
      /// <summary>
      [JsonProperty("status_detail_message")]
      public string StatusDetailMessage { get; set; }

      /// <summary>
      /// 注册发起时间
      /// <summary>
      [JsonProperty("applyed_at")]
      public string ApplyedAt { get; set; }

      /// <summary>
      /// 注册完成时间
      /// <summary>
      [JsonProperty("registed_at")]
      public string RegistedAt { get; set; }

      /// <summary>
      /// 统一社会信用代码
      /// <summary>
      [JsonProperty("uscc")]
      public string Uscc { get; set; }

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