using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 微信实时支付返回
   /// <summary>
   public class CreateWxpayOrderResponseModel : AopObject
   {
      /// <summary>
      /// 平台企业订单号
      /// <summary>
      [JsonProperty("order_id")]
      public string OrderID { get; set; }
      
      /// <summary>
      /// 综合服务平台流水号，唯一
      /// <summary>
      [JsonProperty("ref")]
      public string Ref { get; set; }
      
      /// <summary>
      /// 订单金额
      /// <summary>
      [JsonProperty("pay")]
      public string Pay { get; set; }
      
   }
}