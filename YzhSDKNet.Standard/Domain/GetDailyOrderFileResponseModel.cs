using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日订单文件返回
   /// <summary>
   public class GetDailyOrderFileResponseModel : AopObject
   {
      /// <summary>
      /// 下载地址
      /// <summary>
      [JsonProperty("order_download_url")]
      public string OrderDownloadURL { get; set; }
      
   }
}