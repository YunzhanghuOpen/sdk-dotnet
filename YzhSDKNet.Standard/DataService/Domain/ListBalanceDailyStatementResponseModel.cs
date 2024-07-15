using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询余额日账单数据返回
    /// </summary>
    public class ListBalanceDailyStatementResponseModel : AopObject
    {
        /// <summary>
        /// 条目信息
        /// </summary>
        [JsonProperty("list")]
        public StatementDetail[] List { get; set; }

    }
}