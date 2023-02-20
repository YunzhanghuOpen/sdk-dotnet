using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 银行卡实时支付返回
   /// <summary>
   public class CreateBankpayOrderResponseModel : AopObject
   {
      /// <summary>
      /// order_id
      /// <summary>
      [JsonProperty("order_id")]
      public string OrderID { get; set; }
      
      /// <summary>
      /// 综合服务平台流水号
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