using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 工商实名信息录入返回
   /// <summary>
   public class H5PreCollectBizlicMsgResponseModel : AopObject
   {
      /// <summary>
      /// 平台企业端的用户 ID
      /// <summary>
      [JsonProperty("dealer_user_id")]
      public string DealerUserID { get; set; }
      
   }
}