using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询电子回单请求
   /// <summary>
   public class GetEleReceiptFileRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业订单号
      /// <summary>
      [JsonProperty("order_id")]
      public string OrderID { get; set; }
      
      /// <summary>
      /// 综合服务平台流水号
      /// <summary>
      [JsonProperty("ref")]
      public string Ref { get; set; }
      
   }
}