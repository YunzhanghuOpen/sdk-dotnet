using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 结果回调
   /// <summary>
   public class NotifyH5EcoCityAicRequestModel : AopObject
   {
      /// <summary>
      /// 用户唯一标识
      /// <summary>
      [JsonProperty("open_id")]
      public string OpenID { get; set; }
      
      /// <summary>
      /// 平台企业端的用户 ID
      /// <summary>
      [JsonProperty("dealer_user_id")]
      public string DealerUserID { get; set; }
      
      /// <summary>
      /// 注册/注销提交时间
      /// <summary>
      [JsonProperty("submit_at")]
      public string SubmitAt { get; set; }
      
      /// <summary>
      /// 注册/注销完成时间
      /// <summary>
      [JsonProperty("registed_at")]
      public string RegistedAt { get; set; }
      
      /// <summary>
      /// 用户签约状态
      /// <summary>
      [JsonProperty("status")]
      public int Status { get; set; }
      
      /// <summary>
      /// 注册状态描述
      /// <summary>
      [JsonProperty("status_message")]
      public string StatusMessage { get; set; }
      
      /// <summary>
      /// 注册详情状态码
      /// <summary>
      [JsonProperty("status_detail")]
      public int StatusDetail { get; set; }
      
      /// <summary>
      /// 注册详情状态码描述
      /// <summary>
      [JsonProperty("status_detail_message")]
      public string StatusDetailMessage { get; set; }
      
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
      /// 统一社会信用代码
      /// <summary>
      [JsonProperty("uscc")]
      public string Uscc { get; set; }
      
      /// <summary>
      /// 身份证号码
      /// <summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }
      
      /// <summary>
      /// 姓名
      /// <summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }
      
      /// <summary>
      /// 回调类型
      /// <summary>
      [JsonProperty("type")]
      public int Type { get; set; }
      
   }
}