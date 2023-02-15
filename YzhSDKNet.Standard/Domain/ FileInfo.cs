using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 报税文件详情
   /// <summary>
   public class FileInfo : AopObject
   {
      /// <summary>
      /// 文件名称
      /// <summary>
      [JsonProperty("name")]
      public string Name { get; set; }
      
      /// <summary>
      /// 下载文件临时 URL
      /// <summary>
      [JsonProperty("url")]
      public string URL { get; set; }
      
      /// <summary>
      /// 文件解压缩密码
      /// <summary>
      [JsonProperty("pwd")]
      public string Pwd { get; set; }
      
   }
}