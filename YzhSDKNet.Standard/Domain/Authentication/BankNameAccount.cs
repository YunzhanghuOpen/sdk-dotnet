using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 系统支持的开户行及账号
   /// <summary>
   public class BankNameAccount : AopObject
   {
      /// <summary>
      /// 开户行及账号
      /// <summary>
      [JsonProperty("item")]
      public string Item { get; set; }
      
      /// <summary>
      /// 是否为默认值
      /// <summary>
      [JsonProperty("default")]
      public bool Default { get; set; }
      
   }
}