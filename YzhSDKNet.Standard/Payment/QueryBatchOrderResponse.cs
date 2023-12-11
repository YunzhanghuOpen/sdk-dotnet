using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 查询批次订单信息
   /// </summary>
   public class QueryBatchOrderResponse : AopResponse
   {
      /// <summary>
      /// 查询批次订单信息
      /// </summary>
      [JsonProperty("data")]
      public QueryBatchOrderResponseModel Data { get; set; }
   }
}