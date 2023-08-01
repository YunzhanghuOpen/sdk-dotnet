using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询纳税人是否为跨集团用户请求
   /// </summary>
   public class GetUserCrossRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业 ID
      /// </summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }

      /// <summary>
      /// 年份
      /// </summary>
      [JsonProperty("year")]
      public string Year { get; set; }

      /// <summary>
      /// 身份证号码
      /// </summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }

      /// <summary>
      /// 平台企业签约主体
      /// </summary>
      [JsonProperty("ent_id")]
      public string EntID { get; set; }
   }
}