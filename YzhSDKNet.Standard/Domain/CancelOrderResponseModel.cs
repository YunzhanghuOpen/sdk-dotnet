using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 取消待支付订单返回
   /// <summary>
   public class CancelOrderResponseModel : AopObject
   {
      /// <summary>
      /// ok
      /// <summary>
      [JsonProperty("ok")]
      public string Ok { get; set; }
      
   }
}