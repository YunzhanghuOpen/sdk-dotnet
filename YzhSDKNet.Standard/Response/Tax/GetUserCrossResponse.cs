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
   /// 查询纳税人是否为跨集团用户
   /// <summary>
   public class GetUserCrossResponse : AopResponse
   {
      /// <summary>
      /// 查询纳税人是否为跨集团用户
      /// <summary>
      [JsonProperty("data")]
      public GetUserCrossResponseModel Data { get; set; }

   }
}