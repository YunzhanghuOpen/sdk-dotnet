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
   /// 批次下单
   /// <summary>
   public class CreateBatchOrderResponse : AopResponse
   {
      /// <summary>
      /// 批次下单
      /// <summary>
      [JsonProperty("data")]
      public CreateBatchOrderResponseModel Data { get; set; }

   }
}