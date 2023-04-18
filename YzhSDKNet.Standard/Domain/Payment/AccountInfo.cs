using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 账户信息
   /// <summary>
   public class AccountInfo : AopObject
   {
      /// <summary>
      /// 综合服务主体 ID
      /// <summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }

      /// <summary>
      /// 银行卡余额
      /// <summary>
      [JsonProperty("bank_card_balance")]
      public string BankCardBalance { get; set; }

      /// <summary>
      /// 是否开通银行卡支付路径
      /// <summary>
      [JsonProperty("is_bank_card")]
      public bool IsBankCard { get; set; }

      /// <summary>
      /// 支付宝余额
      /// <summary>
      [JsonProperty("alipay_balance")]
      public string AlipayBalance { get; set; }

      /// <summary>
      /// 是否开通支付宝支付路径
      /// <summary>
      [JsonProperty("is_alipay")]
      public bool IsAlipay { get; set; }

      /// <summary>
      /// 微信余额
      /// <summary>
      [JsonProperty("wxpay_balance")]
      public string WxpayBalance { get; set; }

      /// <summary>
      /// 是否开通微信支付路径
      /// <summary>
      [JsonProperty("is_wxpay")]
      public bool IsWxpay { get; set; }

      /// <summary>
      /// 加成服务费返点余额
      /// <summary>
      [JsonProperty("rebate_fee_balance")]
      public string RebateFeeBalance { get; set; }

      /// <summary>
      /// 业务服务费余额
      /// <summary>
      [JsonProperty("acct_balance")]
      public string AcctBalance { get; set; }

      /// <summary>
      /// 总余额
      /// <summary>
      [JsonProperty("total_balance")]
      public string TotalBalance { get; set; }
   }
}