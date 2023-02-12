using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询平台企业余额返回
   /// <summary>
   public class ListAccountResponseModel : AopObject
   {
      /// <summary>
      /// dealer_infos
      /// <summary>
      [JsonProperty("dealer_infos")]
      public List<AccountInfo> DealerInfos { get; set; }
      
   }
}