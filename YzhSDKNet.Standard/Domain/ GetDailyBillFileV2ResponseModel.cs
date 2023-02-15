using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日流水文件返回
   /// <summary>
   public class GetDailyBillFileV2ResponseModel : AopObject
   {
      /// <summary>
      /// 下载地址
      /// <summary>
      [JsonProperty("bill_download_url")]
      public string BillDownloadURL { get; set; }
      
   }
}