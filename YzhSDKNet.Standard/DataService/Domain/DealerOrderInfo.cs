using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 平台企业支付订单信息
   /// </summary>
   public class DealerOrderInfo : AopObject
   {
      /// <summary>
      /// 综合服务主体 ID
      /// </summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }

      /// <summary>
      /// 平台企业 ID
      /// </summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }

      /// <summary>
      /// 平台企业订单号
      /// </summary>
      [JsonProperty("order_id")]
      public string OrderID { get; set; }

      /// <summary>
      /// 订单流水号
      /// </summary>
      [JsonProperty("ref")]
      public string Ref { get; set; }

      /// <summary>
      /// 批次ID
      /// </summary>
      [JsonProperty("batch_id")]
      public string BatchID { get; set; }

      /// <summary>
      /// 姓名
      /// </summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }

      /// <summary>
      /// 收款账号
      /// </summary>
      [JsonProperty("card_no")]
      public string CardNo { get; set; }

      /// <summary>
      /// 综合服务主体订单金额
      /// </summary>
      [JsonProperty("broker_amount")]
      public string BrokerAmount { get; set; }

      /// <summary>
      /// 综合服务主体加成服务费
      /// </summary>
      [JsonProperty("broker_fee")]
      public string BrokerFee { get; set; }

      /// <summary>
      /// 支付路径流水号
      /// </summary>
      [JsonProperty("bill")]
      public string Bill { get; set; }

      /// <summary>
      /// 订单状态
      /// </summary>
      [JsonProperty("status")]
      public string Status { get; set; }

      /// <summary>
      /// 订单状态码描述
      /// </summary>
      [JsonProperty("status_message")]
      public string StatusMessage { get; set; }

      /// <summary>
      /// 订单详情
      /// </summary>
      [JsonProperty("status_detail")]
      public string StatusDetail { get; set; }

      /// <summary>
      /// 订单详细状态码描述
      /// </summary>
      [JsonProperty("status_detail_message")]
      public string StatusDetailMessage { get; set; }

      /// <summary>
      /// 短周期授信账单号
      /// </summary>
      [JsonProperty("statement_id")]
      public string StatementID { get; set; }

      /// <summary>
      /// 服务费账单号
      /// </summary>
      [JsonProperty("fee_statement_id")]
      public string FeeStatementID { get; set; }

      /// <summary>
      /// 余额账单号
      /// </summary>
      [JsonProperty("bal_statement_id")]
      public string BalStatementID { get; set; }

      /// <summary>
      /// 支付路径
      /// </summary>
      [JsonProperty("channel")]
      public string Channel { get; set; }

      /// <summary>
      /// 创建时间
      /// </summary>
      [JsonProperty("created_at")]
      public string CreatedAt { get; set; }

      /// <summary>
      /// 完成时间
      /// </summary>
      [JsonProperty("finished_time")]
      public string FinishedTime { get; set; }
   }
}