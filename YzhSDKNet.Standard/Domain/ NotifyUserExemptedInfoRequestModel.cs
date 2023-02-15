using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 上传免验证用户名单信息审核结果通知
   /// <summary>
   public class NotifyUserExemptedInfoRequestModel : AopObject
   {
      /// <summary>
      /// 综合服务主体 ID
      /// <summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }
      
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
      /// <summary>
      /// 姓名
      /// <summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }
      
      /// <summary>
      /// 证件号
      /// <summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }
      
      /// <summary>
      /// 审核状态
      /// <summary>
      [JsonProperty("status")]
      public string Status { get; set; }
      
      /// <summary>
      /// 流水号
      /// <summary>
      [JsonProperty("ref")]
      public string Ref { get; set; }
      
      /// <summary>
      /// 审核信息
      /// <summary>
      [JsonProperty("comment")]
      public string Comment { get; set; }
      
   }
}