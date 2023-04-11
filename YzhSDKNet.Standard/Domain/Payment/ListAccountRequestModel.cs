using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询平台企业余额请求
   /// <summary>
   public class ListAccountRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
   }
}