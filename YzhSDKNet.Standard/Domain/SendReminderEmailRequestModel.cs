using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 发送发票扫描件压缩包下载链接邮件请求
   /// <summary>
   public class SendReminderEmailRequestModel : AopObject
   {
      /// <summary>
      /// 发票申请编号
      /// <summary>
      [JsonProperty("invoice_apply_id")]
      public string InvoiceApplyID { get; set; }
      
      /// <summary>
      /// 发票申请单 ID
      /// <summary>
      [JsonProperty("application_id")]
      public string ApplicationID { get; set; }
      
   }
}