using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 系统支持的货物或应税劳务、服务名称
   /// <summary>
   public class GoodsServicesName : AopObject
   {
      /// <summary>
      /// 货物或应税劳务、服务名称
      /// <summary>
      [JsonProperty("item")]
      public string Item { get; set; }

      /// <summary>
      /// 是否为默认值
      /// <summary>
      [JsonProperty("default")]
      public bool Default { get; set; }
   }
}