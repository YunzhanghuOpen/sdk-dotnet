using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 用户签约信息上传请求
   /// </summary>
   public class UploadUserSignRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业 ID
      /// </summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
      /// <summary>
      /// 综合服务主体 ID
      /// </summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }
      
      /// <summary>
      /// 姓名
      /// </summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }
      
      /// <summary>
      /// 证件号码
      /// </summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }
      
      /// <summary>
      /// 手机号
      /// </summary>
      [JsonProperty("phone")]
      public string Phone { get; set; }
      
      /// <summary>
      /// 是否是海外用户
      /// </summary>
      [JsonProperty("is_abroad")]
      public bool IsAbroad { get; set; }
      
      /// <summary>
      /// 签约回调地址
      /// </summary>
      [JsonProperty("notify_url")]
      public string NotifyURL { get; set; }
      
   }
}