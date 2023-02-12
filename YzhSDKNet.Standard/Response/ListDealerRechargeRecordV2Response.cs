using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aop.Api.Domain;


namespace Aop.Api.Response
{
   /// <summary>
   /// 查询平台企业预付业务服务费记录
   /// <summary>
   public class ListDealerRechargeRecordV2Response : AopResponse
   {
      /// <summary>
      /// 查询平台企业预付业务服务费记录
      /// <summary>
      [JsonProperty("data")]
      public List<RechargeRecordInfo> Data { get; set; }

   }
}