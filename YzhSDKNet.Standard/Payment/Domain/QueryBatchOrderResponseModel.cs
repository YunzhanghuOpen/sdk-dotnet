using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询批次订单信息返回
   /// </summary>
   public class QueryBatchOrderResponseModel : AopObject
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
      /// 平台企业批次号
      /// </summary>
      [JsonProperty("batch_id")]
      public string BatchID { get; set; }
      
      /// <summary>
      /// 总笔数
      /// </summary>
      [JsonProperty("total_count")]
      public string TotalCount { get; set; }
      
      /// <summary>
      /// 订单总金额
      /// </summary>
      [JsonProperty("total_pay")]
      public string TotalPay { get; set; }
      
      /// <summary>
      /// 支付路径
      /// </summary>
      [JsonProperty("channel")]
      public string Channel { get; set; }
      
      /// <summary>
      /// 批次状态码
      /// </summary>
      [JsonProperty("batch_status")]
      public string BatchStatus { get; set; }
      
      /// <summary>
      /// 批次状态码描述
      /// </summary>
      [JsonProperty("batch_status_message")]
      public string BatchStatusMessage { get; set; }
      
      /// <summary>
      /// 批次接收时间
      /// </summary>
      [JsonProperty("batch_received_time")]
      public string BatchReceivedTime { get; set; }
      
      /// <summary>
      /// 批次订单列表
      /// </summary>
      [JsonProperty("order_list")]
      public QueryBatchOrderInfo[] OrderList { get; set; }
      
   }
}