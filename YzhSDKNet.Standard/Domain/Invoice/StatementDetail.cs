using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 余额账单信息详情
   /// <summary>
   public class StatementDetail : AopObject
   {
      /// <summary>
      /// 账单 ID
      /// <summary>
      [JsonProperty("statement_id")]
      public string StatementID { get; set; }
      
      /// <summary>
      /// 账单日期
      /// <summary>
      [JsonProperty("statement_date")]
      public string StatementDate { get; set; }
      
      /// <summary>
      /// 综合服务主体 ID
      /// <summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }
      
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
      /// <summary>
      /// 综合服务主体名称
      /// <summary>
      [JsonProperty("broker_product_name")]
      public string BrokerProductName { get; set; }
      
      /// <summary>
      /// 平台企业名称
      /// <summary>
      [JsonProperty("dealer_product_name")]
      public string DealerProductName { get; set; }
      
      /// <summary>
      /// 业务类型
      /// <summary>
      [JsonProperty("biz_type")]
      public string BizType { get; set; }
      
      /// <summary>
      /// 账单金额
      /// <summary>
      [JsonProperty("total_money")]
      public string TotalMoney { get; set; }
      
      /// <summary>
      /// 订单金额
      /// <summary>
      [JsonProperty("amount")]
      public string Amount { get; set; }
      
      /// <summary>
      /// 退汇金额
      /// <summary>
      [JsonProperty("reex_amount")]
      public string ReexAmount { get; set; }
      
      /// <summary>
      /// 加成服务费金额
      /// <summary>
      [JsonProperty("fee_amount")]
      public string FeeAmount { get; set; }
      
      /// <summary>
      /// 加成服务费抵扣金额
      /// <summary>
      [JsonProperty("deduct_rebate_fee_amount")]
      public string DeductRebateFeeAmount { get; set; }
      
      /// <summary>
      /// 冲补金额
      /// <summary>
      [JsonProperty("money_adjust")]
      public string MoneyAdjust { get; set; }
      
      /// <summary>
      /// 账单状态
      /// <summary>
      [JsonProperty("status")]
      public string Status { get; set; }
      
      /// <summary>
      /// 开票状态
      /// <summary>
      [JsonProperty("invoice_status")]
      public string InvoiceStatus { get; set; }
      
      /// <summary>
      /// 项目 ID
      /// <summary>
      [JsonProperty("project_id")]
      public string ProjectID { get; set; }
      
      /// <summary>
      /// 项目名称
      /// <summary>
      [JsonProperty("project_name")]
      public string ProjectName { get; set; }
      
   }
}