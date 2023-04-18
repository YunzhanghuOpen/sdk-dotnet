using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日订单数据请求
   /// <summary>
   public class ListDailyOrderRequestModel : AopObject
   {
      /// <summary>
      /// 订单查询日期, 格式：yyyy-MM-dd格式：yyyy-MM-dd
      /// <summary>
      [JsonProperty("order_date")]
      public string OrderDate { get; set; }

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
      /// 支付路径名，银行卡（默认）、支付宝、微信
      /// <summary>
      [JsonProperty("channel")]
      public string Channel { get; set; }

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