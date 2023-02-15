using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 银行卡信息查询返回
   /// <summary>
   public class GetBankCardInfoResponseModel : AopObject
   {
      /// <summary>
      /// 银行代码
      /// <summary>
      [JsonProperty("bank_code")]
      public string BankCode { get; set; }
      
      /// <summary>
      /// 银行名称
      /// <summary>
      [JsonProperty("bank_name")]
      public string BankName { get; set; }
      
      /// <summary>
      /// 卡类型
      /// <summary>
      [JsonProperty("card_type")]
      public string CardType { get; set; }
      
      /// <summary>
      /// 云账户是否支持向该银行支付
      /// <summary>
      [JsonProperty("is_support")]
      public bool IsSupport { get; set; }
      
   }
}