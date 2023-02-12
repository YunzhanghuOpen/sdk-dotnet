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
   /// 用户解约（测试账号专用接口）
   /// <summary>
   public class ApiUserSignReleaseResponse : AopResponse
   {
      /// <summary>
      /// 用户解约（测试账号专用接口）
      /// <summary>
      [JsonProperty("data")]
      public ApiUserSignReleaseResponseModel Data { get; set; }

   }
}