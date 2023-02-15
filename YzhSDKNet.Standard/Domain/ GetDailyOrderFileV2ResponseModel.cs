using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日订单文件（支付和退款订单）返回
   /// <summary>
   public class GetDailyOrderFileV2ResponseModel : AopObject
   {
      /// <summary>
      /// 下载地址
      /// <summary>
      [JsonProperty("url")]
      public string URL { get; set; }
      
   }
}