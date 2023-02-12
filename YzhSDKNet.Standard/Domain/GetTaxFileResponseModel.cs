using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 下载个税扣缴明细表返回
   /// <summary>
   public class GetTaxFileResponseModel : AopObject
   {
      /// <summary>
      /// 文件详情
      /// <summary>
      [JsonProperty("file_info")]
      public List<FileInfo> FileInfo { get; set; }
      
   }
}