using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 上传免验证用户名单信息请求
   /// <summary>
   public class UserExemptedInfoRequestModel : AopObject
   {
      /// <summary>
      /// 证件类型码
      /// <summary>
      [JsonProperty("card_type")]
      public string CardType { get; set; }
      
      /// <summary>
      /// 证件号码
      /// <summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }
      
      /// <summary>
      /// 姓名
      /// <summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }
      
      /// <summary>
      /// 申请备注
      /// <summary>
      [JsonProperty("comment_apply")]
      public string CommentApply { get; set; }
      
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
      /// 人员信息图片
      /// <summary>
      [JsonProperty("user_images")]
      public List<string> UserImages { get; set; }
      
      /// <summary>
      /// 国别（地区）代码
      /// <summary>
      [JsonProperty("country")]
      public string Country { get; set; }
      
      /// <summary>
      /// 出生日期
      /// <summary>
      [JsonProperty("birthday")]
      public string Birthday { get; set; }
      
      /// <summary>
      /// 性别
      /// <summary>
      [JsonProperty("gender")]
      public string Gender { get; set; }
      
      /// <summary>
      /// 回调地址
      /// <summary>
      [JsonProperty("notify_url")]
      public string NotifyURL { get; set; }
      
      /// <summary>
      /// 请求流水号
      /// <summary>
      [JsonProperty("ref")]
      public string Ref { get; set; }
      
   }
}