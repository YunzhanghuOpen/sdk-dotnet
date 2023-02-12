using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// H5 签约接口返回
   /// <summary>
   public class H5UserSignResponseModel : AopObject
   {
      /// <summary>
      /// H5 签约页面 URL
      /// <summary>
      [JsonProperty("url")]
      public string URL { get; set; }
      
   }
}