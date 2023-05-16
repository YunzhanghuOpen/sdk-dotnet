using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询单笔订单信息请求
   /// <summary>
   public class GetOrderRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业订单号
      /// <summary>
      [JsonProperty("order_id")]
      public string OrderID { get; set; }

      /// <summary>
      /// 支付路径名，银行卡（默认）、支付宝、微信
      /// <summary>
      [JsonProperty("channel")]
      public string Channel { get; set; }

      /// <summary>
      /// 数据类型，如果为 encryption，则对返回的 data 进行加密
      /// <summary>
      [JsonProperty("data_type")]
      public string DataType { get; set; }

        /// <summary>
        /// 数据是否加密返回，默认否，非所有接口均支持加密返回
        /// </summary>
        /// <returns>接口响应数据是否加密</returns>
        public override bool IsNeedEncrypt()
        {
            return this.DataType == "encryption";
        }
   }
}