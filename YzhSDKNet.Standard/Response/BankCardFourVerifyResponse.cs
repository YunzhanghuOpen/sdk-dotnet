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
   /// 银行卡四要素验证
   /// <summary>
   public class BankCardFourVerifyResponse : AopResponse
   {
      /// <summary>
      /// 银行卡四要素验证
      /// <summary>
      [JsonProperty("data")]
      public BankCardFourVerifyResponseModel Data { get; set; }

   }
}