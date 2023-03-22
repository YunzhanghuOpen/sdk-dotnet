using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询发票信息返回
   /// <summary>
   public class InformationDataInfo : AopObject
   {
      /// <summary>
      /// 货物或应税劳务、服务名称
      /// <summary>
      [JsonProperty("goods_services_name")]
      public string GoodsServicesName { get; set; }
      
      /// <summary>
      /// 发票号码
      /// <summary>
      [JsonProperty("invoice_num")]
      public string InvoiceNum { get; set; }
      
      /// <summary>
      /// 发票代码
      /// <summary>
      [JsonProperty("invoice_code")]
      public string InvoiceCode { get; set; }
      
      /// <summary>
      /// 不含税金额
      /// <summary>
      [JsonProperty("price_amount")]
      public string PriceAmount { get; set; }
      
      /// <summary>
      /// 税额
      /// <summary>
      [JsonProperty("tax_amount")]
      public string TaxAmount { get; set; }
      
      /// <summary>
      /// 税率
      /// <summary>
      [JsonProperty("tax_rate")]
      public string TaxRate { get; set; }
      
      /// <summary>
      /// 价税合计
      /// <summary>
      [JsonProperty("price_tax_amount")]
      public string PriceTaxAmount { get; set; }
      
      /// <summary>
      /// 开票日期
      /// <summary>
      [JsonProperty("invoiced_date")]
      public string InvoicedDate { get; set; }
      
   }
}