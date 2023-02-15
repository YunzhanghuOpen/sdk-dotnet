using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日流水文件请求
   /// <summary>
   public class GetDailyBillFileV2RequestModel : AopObject
   {
      /// <summary>
      /// 所需获取的日流水日期，格式：yyyy-MM-dd
      /// <summary>
      [JsonProperty("bill_date")]
      public string BillDate { get; set; }
      
   }
}