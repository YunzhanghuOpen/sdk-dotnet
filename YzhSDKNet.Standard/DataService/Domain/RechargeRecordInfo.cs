using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 预付业务服务费记录信息
   /// </summary>
   public class RechargeRecordInfo : AopObject
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
      /// 预付业务服务费记录 ID
      /// </summary>
      [JsonProperty("recharge_id")]
      public string RechargeID { get; set; }

      /// <summary>
      /// 预付业务服务费
      /// </summary>
      [JsonProperty("amount")]
      public string Amount { get; set; }

      /// <summary>
      /// 实际到账金额
      /// </summary>
      [JsonProperty("actual_amount")]
      public string ActualAmount { get; set; }

      /// <summary>
      /// 创建时间
      /// </summary>
      [JsonProperty("created_at")]
      public string CreatedAt { get; set; }

      /// <summary>
      /// 资金用途
      /// </summary>
      [JsonProperty("recharge_channel")]
      public string RechargeChannel { get; set; }

      /// <summary>
      /// 预付业务服务费备注
      /// </summary>
      [JsonProperty("remark")]
      public string Remark { get; set; }

      /// <summary>
      /// 平台企业付款银行账号
      /// </summary>
      [JsonProperty("recharge_account_no")]
      public string RechargeAccountNo { get; set; }
   }
}