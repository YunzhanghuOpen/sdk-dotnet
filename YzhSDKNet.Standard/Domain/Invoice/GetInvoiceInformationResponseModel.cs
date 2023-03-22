using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询发票信息返回
   /// <summary>
   public class GetInvoiceInformationResponseModel : AopObject
   {
      /// <summary>
      /// 发票信息
      /// <summary>
      [JsonProperty("information")]
      public InformationDataInfo[] Information { get; set; }
      
   }
}