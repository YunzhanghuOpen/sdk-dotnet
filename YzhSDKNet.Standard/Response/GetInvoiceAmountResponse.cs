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
   /// 查询可开票额度和开票信息
   /// <summary>
   public class GetInvoiceAmountResponse : AopResponse
   {
      /// <summary>
      /// 查询可开票额度和开票信息
      /// <summary>
      [JsonProperty("data")]
      public GetInvoiceAmountResponseModel Data { get; set; }

   }
}