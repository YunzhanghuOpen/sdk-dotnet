using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询余额日账单数据返回
   /// <summary>
   public class ListBalanceDailyStatementResponseModel : AopObject
   {
      /// <summary>
      /// 条目信息
      /// <summary>
      [JsonProperty("list")]
      public List<StatementDetail> List { get; set; }
      
   }
}