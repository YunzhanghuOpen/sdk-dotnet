using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询平台企业汇款信息返回
   /// </summary>
   public class GetDealerVARechargeAccountResponseModel : AopObject
   {
      /// <summary>
      /// 账户名称
      /// </summary>
      [JsonProperty("acct_name")]
      public string AcctName { get; set; }

      /// <summary>
      /// 专属账户
      /// </summary>
      [JsonProperty("acct_no")]
      public string AcctNo { get; set; }

      /// <summary>
      /// 银行名称
      /// </summary>
      [JsonProperty("bank_name")]
      public string BankName { get; set; }

      /// <summary>
      /// 付款账户
      /// </summary>
      [JsonProperty("dealer_acct_name")]
      public string DealerAcctName { get; set; }
   }
}