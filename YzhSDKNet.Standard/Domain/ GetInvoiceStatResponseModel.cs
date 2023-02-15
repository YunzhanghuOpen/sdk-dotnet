using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询平台企业已开具和待开具发票金额返回
   /// <summary>
   public class GetInvoiceStatResponseModel : AopObject
   {
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
      /// <summary>
      /// 综合服务主体 ID
      /// <summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }
      
      /// <summary>
      /// 已开具发票金额
      /// <summary>
      [JsonProperty("invoiced")]
      public string Invoiced { get; set; }
      
      /// <summary>
      /// 待开具发票金额
      /// <summary>
      [JsonProperty("not_invoiced")]
      public string NotInvoiced { get; set; }
      
   }
}