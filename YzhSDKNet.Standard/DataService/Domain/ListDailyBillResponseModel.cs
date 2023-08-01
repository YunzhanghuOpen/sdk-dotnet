using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日流水数据返回
   /// </summary>
   public class ListDailyBillResponseModel : AopObject
   {
      /// <summary>
      /// 总条数
      /// </summary>
      [JsonProperty("total_num")]
      public int TotalNum { get; set; }

      /// <summary>
      /// 条目信息
      /// </summary>
      [JsonProperty("list")]
      public DealerBillInfo[] List { get; set; }
   }
}