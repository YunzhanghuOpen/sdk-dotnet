using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 下载 PDF 版发票返回
   /// <summary>
   public class GetInvoiceFileResponseModel : AopObject
   {
      /// <summary>
      /// 下载地址
      /// <summary>
      [JsonProperty("url")]
      public string URL { get; set; }
      
      /// <summary>
      /// 文件名称
      /// <summary>
      [JsonProperty("name")]
      public string Name { get; set; }
      
   }
}