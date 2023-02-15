using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 平台企业预付业务服务费记录请求
   /// <summary>
   public class ListDealerRechargeRecordV2RequestModel : AopObject
   {
      /// <summary>
      /// 开始时间，格式：yyyy-MM-dd
      /// <summary>
      [JsonProperty("begin_at")]
      public string BeginAt { get; set; }
      
      /// <summary>
      /// 结束时间，格式：yyyy-MM-dd
      /// <summary>
      [JsonProperty("end_at")]
      public string EndAt { get; set; }
      
   }
}