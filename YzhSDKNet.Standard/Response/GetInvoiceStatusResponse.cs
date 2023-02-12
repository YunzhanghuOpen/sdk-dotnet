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
   /// 查询开票申请状态
   /// <summary>
   public class GetInvoiceStatusResponse : AopResponse
   {
      /// <summary>
      /// 查询开票申请状态
      /// <summary>
      [JsonProperty("data")]
      public GetInvoiceStatusResponseModel Data { get; set; }

   }
}