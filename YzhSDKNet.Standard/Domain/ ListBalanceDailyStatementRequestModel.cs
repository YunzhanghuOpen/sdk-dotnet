using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询余额日账单数据请求
   /// <summary>
   public class ListBalanceDailyStatementRequestModel : AopObject
   {
      /// <summary>
      /// 账单查询日期 格式：yyyy-MM-dd
      /// <summary>
      [JsonProperty("statement_date")]
      public string StatementDate { get; set; }
      
   }
}