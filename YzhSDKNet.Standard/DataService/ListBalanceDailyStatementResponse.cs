using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 查询余额日账单数据
   /// </summary>
   public class ListBalanceDailyStatementResponse : AopResponse
   {
      /// <summary>
      /// 查询余额日账单数据
      /// </summary>
      [JsonProperty("data")]
      public ListBalanceDailyStatementResponseModel Data { get; set; }
   }
}