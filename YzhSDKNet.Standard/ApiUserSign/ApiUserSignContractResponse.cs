using Newtonsoft.Json;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
   /// <summary>
   /// 获取协议预览 URL
   /// </summary>
   public class ApiUserSignContractResponse : AopResponse
   {
      /// <summary>
      /// 获取协议预览 URL
      /// </summary>
      [JsonProperty("data")]
      public ApiUserSignContractResponseModel Data { get; set; }
   }
}