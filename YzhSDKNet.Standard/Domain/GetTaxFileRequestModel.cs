using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 下载个税扣缴明细表请求
   /// <summary>
   public class GetTaxFileRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
      /// <summary>
      /// 平台企业签约主体
      /// <summary>
      [JsonProperty("ent_id")]
      public string EntID { get; set; }
      
      /// <summary>
      /// 所属期
      /// <summary>
      [JsonProperty("year_month")]
      public string YearMonth { get; set; }
      
   }
}