using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日流水数据请求
   /// <summary>
   public class ListDailyBillRequestModel : AopObject
   {
      /// <summary>
      /// 流水查询日期
      /// <summary>
      [JsonProperty("bill_date")]
      public string BillDate { get; set; }
      
      /// <summary>
      /// 偏移量
      /// <summary>
      [JsonProperty("offset")]
      public int Offset { get; set; }
      
      /// <summary>
      /// 长度
      /// <summary>
      [JsonProperty("length")]
      public int Length { get; set; }
      
      /// <summary>
      /// 如果为 encryption，则对返回的 data 进行加密
      /// <summary>
      [JsonProperty("data_type")]
      public string DataType { get; set; }
      
      /// <summary>
      /// 数据是否加密返回，默认否，非所有接口均支持加密返回
      /// </summary>
      /// <returns>接口响应数据是否加密</returns>
      public override bool GetNeedEncrypt()
      {
          return this.DataType == "encryption";
      }
      
   }
}