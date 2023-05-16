using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 查询日订单数据
   /// <summary>
   public class ListDailyOrderResponse : AopResponse
   {
      /// <summary>
      /// 查询日订单数据
      /// <summary>
      [JsonProperty("data")]
      public ListDailyOrderResponseModel Data { get; set; }
   }
}