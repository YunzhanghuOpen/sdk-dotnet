using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// H5 预申请签约接口返回
   /// <summary>
   public class H5UserPresignResponseModel : AopObject
   {
      /// <summary>
      /// 用户 ID（废弃字段）
      /// <summary>
      [JsonProperty("uid")]
      public string Uid { get; set; }
      
      /// <summary>
      /// H5 签约 token
      /// <summary>
      [JsonProperty("token")]
      public string Token { get; set; }
      
   }
}