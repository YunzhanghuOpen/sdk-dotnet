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
   /// 查询个体工商户状态
   /// <summary>
   public class H5EcoCityAicStatusResponse : AopResponse
   {
      /// <summary>
      /// 查询个体工商户状态
      /// <summary>
      [JsonProperty("data")]
      public H5EcoCityAicStatusResponseModel Data { get; set; }

   }
}