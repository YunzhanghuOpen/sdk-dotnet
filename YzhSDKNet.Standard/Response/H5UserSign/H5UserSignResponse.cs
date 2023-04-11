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
   /// 申请签约
   /// <summary>
   public class H5UserSignResponse : AopResponse
   {
      /// <summary>
      /// 申请签约
      /// <summary>
      [JsonProperty("data")]
      public H5UserSignResponseModel Data { get; set; }

   }
}