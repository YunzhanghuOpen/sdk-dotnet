using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 批量下单请求
   /// <summary>
   public class CreateBatchOrderRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业批次号
      /// <summary>
      [JsonProperty("batch_id")]
      public string BatchID { get; set; }
      
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
      /// <summary>
      /// 综合服务主体 ID
      /// <summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }
      
      /// <summary>
      /// 支付路径
      /// <summary>
      [JsonProperty("channel")]
      public string Channel { get; set; }
      
      /// <summary>
      /// 平台企业的微信 AppID
      /// <summary>
      [JsonProperty("wx_app_id")]
      public string WxAppID { get; set; }
      
      /// <summary>
      /// 订单总金额
      /// <summary>
      [JsonProperty("total_pay")]
      public string TotalPay { get; set; }
      
      /// <summary>
      /// 总笔数
      /// <summary>
      [JsonProperty("total_count")]
      public string TotalCount { get; set; }
      
      /// <summary>
      /// 订单列表
      /// <summary>
      [JsonProperty("order_list")]
      public BatchOrderInfo[] OrderList { get; set; }
      
   }
}