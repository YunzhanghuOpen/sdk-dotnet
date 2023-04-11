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
   /// 发票开具申请
   /// <summary>
   public class ApplyInvoiceResponse : AopResponse
   {
      /// <summary>
      /// 发票开具申请
      /// <summary>
      [JsonProperty("data")]
      public ApplyInvoiceResponseModel Data { get; set; }

   }
}