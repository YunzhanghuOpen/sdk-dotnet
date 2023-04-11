using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询纳税人是否为跨集团用户返回
   /// <summary>
   public class GetUserCrossResponseModel : AopObject
   {
      /// <summary>
      /// 跨集团标识
      /// <summary>
      [JsonProperty("is_cross")]
      public bool IsCross { get; set; }
      
   }
}