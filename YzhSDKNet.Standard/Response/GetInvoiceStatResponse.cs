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
   /// 查询平台企业已开具和待开具发票金额
   /// <summary>
   public class GetInvoiceStatResponse : AopResponse
   {
      /// <summary>
      /// 查询平台企业已开具和待开具发票金额
      /// <summary>
      [JsonProperty("data")]
      public GetInvoiceStatResponseModel Data { get; set; }

   }
}