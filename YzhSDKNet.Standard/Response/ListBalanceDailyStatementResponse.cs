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
   /// 获取余额日账单
   /// <summary>
   public class ListBalanceDailyStatementResponse : AopResponse
   {
      /// <summary>
      /// 获取余额日账单
      /// <summary>
      [JsonProperty("data")]
      public ListBalanceDailyStatementResponseModel Data { get; set; }

   }
}