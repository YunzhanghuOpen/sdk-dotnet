using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询日订单数据（支付和退款订单）请求
    /// </summary>
    public class ListDailyOrderV2RequestModel : AopObject
    {
        /// <summary>
        /// 订单查询日期, yyyy-MM-dd 格式
        /// </summary>
        [JsonProperty("order_date")]
        public string OrderDate { get; set; }
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
        
        /// <summary>
        /// 每页返回条数
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }
        
        /// <summary>
        /// 支付路径名，bankpay：银行卡 alipay：支付宝 wxpay：微信
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }
        
        /// <summary>
        /// 当且仅当参数值为 encryption 时，对返回的 data 进行加密
        /// </summary>
        [JsonProperty("data_type")]
        public string DataType { get; set; }
        
        /// <summary>
        /// 数据是否加密返回，默认否，非所有接口均支持加密返回
        /// </summary>
        /// <returns>接口响应数据是否加密</returns>
        public override bool IsNeedEncrypt()
        {
            return this.DataType == "encryption";
        }
        
    }
}