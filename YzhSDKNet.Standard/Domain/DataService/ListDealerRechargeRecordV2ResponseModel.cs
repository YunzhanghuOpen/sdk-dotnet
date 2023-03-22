using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 平台企业预付业务服务费记录返回
   /// <summary>
   public class ListDealerRechargeRecordV2ResponseModel : AopObject
   {
      /// <summary>
      /// 预付业务服务费记录
      /// <summary>
      [JsonProperty("data")]
      public RechargeRecordInfo[] Data { get; set; }
      
   }
}