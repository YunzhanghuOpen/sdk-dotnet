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
   /// 微信实时下单
   /// <summary>
   public class CreateWxpayOrderResponse : AopResponse
   {
      /// <summary>
      /// 微信实时下单
      /// <summary>
      [JsonProperty("data")]
      public CreateWxpayOrderResponseModel Data { get; set; }

   }
}