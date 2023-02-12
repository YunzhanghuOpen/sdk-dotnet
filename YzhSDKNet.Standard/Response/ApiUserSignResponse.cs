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
   /// 用户签约
   /// <summary>
   public class ApiUserSignResponse : AopResponse
   {
      /// <summary>
      /// 用户签约
      /// <summary>
      [JsonProperty("data")]
      public ApiUserSignResponseModel Data { get; set; }

   }
}