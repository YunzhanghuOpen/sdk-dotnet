using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日流水数据返回
   /// <summary>
   public class ListDailyBillResponseModel : AopObject
   {
      /// <summary>
      /// 总条数
      /// <summary>
      [JsonProperty("total_num")]
      public int TotalNum { get; set; }
      
      /// <summary>
      /// 条目信息
      /// <summary>
      [JsonProperty("bills")]
      public List<DealerBillInfo> Bills { get; set; }
      
   }
}