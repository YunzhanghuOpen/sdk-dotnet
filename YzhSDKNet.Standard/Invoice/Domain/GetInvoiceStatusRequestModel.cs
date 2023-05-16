using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询发票开具申请状态请求
   /// <summary>
   public class GetInvoiceStatusRequestModel : AopObject
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