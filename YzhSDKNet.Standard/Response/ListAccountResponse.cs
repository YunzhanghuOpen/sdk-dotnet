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
   /// 查询平台企业余额
   /// <summary>
   public class ListAccountResponse : AopResponse
   {
      /// <summary>
      /// 查询平台企业余额
      /// <summary>
      [JsonProperty("data")]
      public ListAccountResponseModel Data { get; set; }

   }
}