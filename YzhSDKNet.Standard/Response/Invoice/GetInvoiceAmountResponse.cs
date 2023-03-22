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
   /// 查询可开具发票额度和发票开具信息
   /// <summary>
   public class GetInvoiceAmountResponse : AopResponse
   {
      /// <summary>
      /// 查询可开具发票额度和发票开具信息
      /// <summary>
      [JsonProperty("data")]
      public GetInvoiceAmountResponseModel Data { get; set; }

   }
}