using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日订单文件请求
   /// <summary>
   public class GetDailyOrderFileRequestModel : AopObject
   {
      /// <summary>
      /// 订单查询日期, 格式：yyyy-MM-dd
      /// <summary>
      [JsonProperty("order_date")]
      public string OrderDate { get; set; }
      
   }
}