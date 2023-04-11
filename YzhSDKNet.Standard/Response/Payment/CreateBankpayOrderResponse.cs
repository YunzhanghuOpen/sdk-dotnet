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
   /// 银行卡实时支付
   /// <summary>
   public class CreateBankpayOrderResponse : AopResponse
   {
      /// <summary>
      /// 银行卡实时支付
      /// <summary>
      [JsonProperty("data")]
      public CreateBankpayOrderResponseModel Data { get; set; }

   }
}