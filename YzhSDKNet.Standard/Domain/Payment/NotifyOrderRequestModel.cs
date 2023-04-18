using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 订单支付状态回调通知
   /// <summary>
   public class NotifyOrderRequestModel : AopObject
   {
      /// <summary>
      /// 通知 ID
      /// <summary>
      [JsonProperty("notify_id")]
      public string NotifyID { get; set; }

      /// <summary>
      /// 通知时间
      /// <summary>
      [JsonProperty("notify_time")]
      public string NotifyTime { get; set; }

      /// <summary>
      /// 返回数据
      /// <summary>
      [JsonProperty("data")]
      public NotifyOrderData Data { get; set; }
   }
}