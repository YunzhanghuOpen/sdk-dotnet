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
   /// 支付宝实时下单
   /// <summary>
   public class CreateAlipayOrderResponse : AopResponse
   {
      /// <summary>
      /// 支付宝实时下单
      /// <summary>
      [JsonProperty("data")]
      public CreateAlipayOrderResponseModel Data { get; set; }

   }
}