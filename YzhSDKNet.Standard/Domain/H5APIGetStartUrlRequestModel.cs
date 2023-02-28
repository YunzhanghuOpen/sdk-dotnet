using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 预启动请求
   /// <summary>
   public class H5APIGetStartUrlRequestModel : AopObject
   {
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
      /// 平台企业端的用户 ID
      /// <summary>
      [JsonProperty("dealer_user_id")]
      public string DealerUserID { get; set; }
      
      /// <summary>
      /// 客户端类型
      /// <summary>
      [JsonProperty("client_type")]
      public int ClientType { get; set; }
      
      /// <summary>
      /// 异步通知 URL
      /// <summary>
      [JsonProperty("notify_url")]
      public string NotifyURL { get; set; }
      
      /// <summary>
      /// H5 页面主题颜色
      /// <summary>
      [JsonProperty("color")]
      public string Color { get; set; }
      
      /// <summary>
      /// 跳转 URL
      /// <summary>
      [JsonProperty("return_url")]
      public string ReturnURL { get; set; }
      
      /// <summary>
      /// H5 页面 Title
      /// <summary>
      [JsonProperty("customer_title")]
      public int CustomerTitle { get; set; }
      
   }
}