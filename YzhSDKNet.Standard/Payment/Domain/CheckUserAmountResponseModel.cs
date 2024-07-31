using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 用户结算金额校验返回
    /// </summary>
    public class CheckUserAmountResponseModel : AopObject
    {
        /// <summary>
        /// 是否超过月限额
        /// </summary>
        [JsonProperty("is_over_whole_user_month_quota")]
        public bool IsOverWholeUserMonthQuota { get; set; }
        
        /// <summary>
        /// 是否超过年限额
        /// </summary>
        [JsonProperty("is_over_whole_user_year_quota")]
        public bool IsOverWholeUserYearQuota { get; set; }
        
    }
}