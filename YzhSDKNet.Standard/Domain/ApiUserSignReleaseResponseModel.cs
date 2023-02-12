using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 用户解约返回
   /// <summary>
   public class ApiUserSignReleaseResponseModel : AopObject
   {
      /// <summary>
      /// 是否解约成功
      /// <summary>
      [JsonProperty("status")]
      public string Status { get; set; }
      
   }
}