using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 银行卡四要素鉴权返回
   /// <summary>
   public class BankCardFourAuthVerifyResponseModel : AopObject
   {
      /// <summary>
      /// 交易凭证
      /// <summary>
      [JsonProperty("ref")]
      public string Ref { get; set; }
      
   }
}