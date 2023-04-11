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
   /// 身份证实名验证
   /// <summary>
   public class IDCardVerifyResponse : AopResponse
   {
      /// <summary>
      /// 身份证实名验证
      /// <summary>
      [JsonProperty("data")]
      public IDCardVerifyResponseModel Data { get; set; }

   }
}