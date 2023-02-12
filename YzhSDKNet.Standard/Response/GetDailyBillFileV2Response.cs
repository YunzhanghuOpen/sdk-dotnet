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
   /// 查询日流水文件
   /// <summary>
   public class GetDailyBillFileV2Response : AopResponse
   {
      /// <summary>
      /// 查询日流水文件
      /// <summary>
      [JsonProperty("data")]
      public GetDailyBillFileV2ResponseModel Data { get; set; }

   }
}