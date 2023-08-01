using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 微信实时支付请求
   /// </summary>
   public class CreateWxpayOrderRequestModel : AopObject
   {
      /// <summary>
      /// 平台企业订单号
      /// </summary>
      [JsonProperty("order_id")]
      public string OrderID { get; set; }

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
      /// 微信用户 openid
      /// </summary>
      [JsonProperty("openid")]
      public string Openid { get; set; }

      /// <summary>
      /// 身份证号码
      /// </summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }

      /// <summary>
      /// 手机号
      /// </summary>
      [JsonProperty("phone_no")]
      public string PhoneNo { get; set; }

      /// <summary>
      /// 订单金额
      /// </summary>
      [JsonProperty("pay")]
      public string Pay { get; set; }

      /// <summary>
      /// 订单备注
      /// </summary>
      [JsonProperty("pay_remark")]
      public string PayRemark { get; set; }

      /// <summary>
      /// 回调地址
      /// </summary>
      [JsonProperty("notify_url")]
      public string NotifyURL { get; set; }

      /// <summary>
      /// 平台企业微信 AppID
      /// </summary>
      [JsonProperty("wx_app_id")]
      public string WxAppID { get; set; }

      /// <summary>
      /// 微信支付模式，固定值：transfer
      /// </summary>
      [JsonProperty("wxpay_mode")]
      public string WxpayMode { get; set; }

      /// <summary>
      /// 项目标识
      /// </summary>
      [JsonProperty("project_id")]
      public string ProjectID { get; set; }

      /// <summary>
      /// 描述信息，该字段已废弃
      /// </summary>
      [JsonProperty("notes")]
      public string Notes { get; set; }
   }
}