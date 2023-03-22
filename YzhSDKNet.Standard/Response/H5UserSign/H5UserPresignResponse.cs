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
   /// 预申请签约
   /// <summary>
   public class H5UserPresignResponse : AopResponse
   {
      /// <summary>
      /// 预申请签约
      /// <summary>
      [JsonProperty("data")]
      public H5UserPresignResponseModel Data { get; set; }

   }
}