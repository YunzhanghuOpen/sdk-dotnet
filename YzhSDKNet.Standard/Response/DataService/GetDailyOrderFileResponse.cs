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
   /// 查询日订单文件
   /// <summary>
   public class GetDailyOrderFileResponse : AopResponse
   {
      /// <summary>
      /// 查询日订单文件
      /// <summary>
      [JsonProperty("data")]
      public GetDailyOrderFileResponseModel Data { get; set; }

   }
}