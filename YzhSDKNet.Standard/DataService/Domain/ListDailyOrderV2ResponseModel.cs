using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询日订单数据（支付和退款订单）返回
    /// </summary>
    public class ListDailyOrderV2ResponseModel : AopObject
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_num")]
        public int TotalNum { get; set; }
        
        /// <summary>
        /// 条目明细
        /// </summary>
        [JsonProperty("list")]
        public DealerOrderInfoV2[] List { get; set; }
        
    }
}