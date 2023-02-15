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
   /// 工商实名信息录入
   /// <summary>
   public class H5PreCollectBizlicMsgResponse : AopResponse
   {
      /// <summary>
      /// 工商实名信息录入
      /// <summary>
      [JsonProperty("data")]
      public H5PreCollectBizlicMsgResponseModel Data { get; set; }

   }
}