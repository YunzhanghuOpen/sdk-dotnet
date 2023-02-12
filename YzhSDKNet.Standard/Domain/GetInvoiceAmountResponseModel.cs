using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询可开票额度和开票信息返回
   /// <summary>
   public class GetInvoiceAmountResponseModel : AopObject
   {
      /// <summary>
      /// 可开票额度
      /// <summary>
      [JsonProperty("amount")]
      public string Amount { get; set; }
      
      /// <summary>
      /// 系统支持的开户行及账号
      /// <summary>
      [JsonProperty("bank_name_account")]
      public List<BankNameAccount> BankNameAccount { get; set; }
      
      /// <summary>
      /// 系统支持的货物或应税劳务、服务名称
      /// <summary>
      [JsonProperty("goods_services_name")]
      public List<GoodsServicesName> GoodsServicesName { get; set; }
      
   }
}