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
   /// 查询单笔订单信息
   /// <summary>
   public class GetOrderResponse : AopResponse
   {
      /// <summary>
      /// 查询单笔订单信息
      /// <summary>
      [JsonProperty("data")]
      public GetOrderResponseModel Data { get; set; }

   }
}