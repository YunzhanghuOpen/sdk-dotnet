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
   /// 获取用户签约状态
   /// <summary>
   public class GetApiUserSignStatusResponse : AopResponse
   {
      /// <summary>
      /// 获取用户签约状态
      /// <summary>
      [JsonProperty("data")]
      public GetApiUserSignStatusResponseModel Data { get; set; }

   }
}