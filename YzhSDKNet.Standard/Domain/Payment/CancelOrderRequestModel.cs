using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 取消待支付订单请求
   /// <summary>
   public class CancelOrderRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }

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

      /// <summary>
      /// 支付路径名，银行卡（默认）、支付宝、微信
      /// <summary>
      [JsonProperty("channel")]
      public string Channel { get; set; }
   }
}