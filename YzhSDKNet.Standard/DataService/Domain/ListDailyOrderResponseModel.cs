using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日订单数据返回
   /// </summary>
   public class ListDailyOrderResponseModel : AopObject
   {
      /// <summary>
      /// 总数目
      /// </summary>
      [JsonProperty("total_num")]
      public int TotalNum { get; set; }

      /// <summary>
      /// 条目信息
      /// </summary>
      [JsonProperty("list")]
      public DealerOrderInfo[] List { get; set; }
   }
}