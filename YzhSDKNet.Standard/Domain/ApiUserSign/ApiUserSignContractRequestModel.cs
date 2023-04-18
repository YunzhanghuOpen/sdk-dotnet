using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 获取协议预览 URL 请求
   /// <summary>
   public class ApiUserSignContractRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }

      /// <summary>
      /// 综合服务主体 ID
      /// <summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }
   }
}