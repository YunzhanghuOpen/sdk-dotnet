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
   /// 查询平台企业汇款信息
   /// <summary>
   public class GetDealerVARechargeAccountResponse : AopResponse
   {
      /// <summary>
      /// 查询平台企业汇款信息
      /// <summary>
      [JsonProperty("data")]
      public GetDealerVARechargeAccountResponseModel Data { get; set; }

   }
}