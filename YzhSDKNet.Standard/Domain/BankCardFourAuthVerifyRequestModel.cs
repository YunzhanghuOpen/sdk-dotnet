using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 银行卡四要素鉴权请求
   /// <summary>
   public class BankCardFourAuthVerifyRequestModel : AopObject
   {
      /// <summary>
      /// 银行卡号
      /// <summary>
      [JsonProperty("card_no")]
      public string CardNo { get; set; }
      
      /// <summary>
      /// 身份证号码
      /// <summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }
      
      /// <summary>
      /// 姓名
      /// <summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }
      
      /// <summary>
      /// 银行预留手机号
      /// <summary>
      [JsonProperty("mobile")]
      public string Mobile { get; set; }
      
   }
}