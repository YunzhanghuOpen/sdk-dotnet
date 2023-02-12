using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aop.Api.Domain;


namespace Aop.Api.Response
{
   /// <summary>
   /// 上传免验证用户名单信息
   /// <summary>
   public class UserExemptedInfoResponse : AopResponse
   {
      /// <summary>
      /// 上传免验证用户名单信息
      /// <summary>
      [JsonProperty("data")]
      public UserExemptedInfoResponseModel Data { get; set; }

   }
}