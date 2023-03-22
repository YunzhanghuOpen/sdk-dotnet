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
   /// 查询日流水数据
   /// <summary>
   public class ListDailyBillResponse : AopResponse
   {
      /// <summary>
      /// 查询日流水数据
      /// <summary>
      [JsonProperty("data")]
      public ListDailyBillResponseModel Data { get; set; }

   }
}