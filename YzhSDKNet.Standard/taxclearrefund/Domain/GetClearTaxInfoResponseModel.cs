using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询税费清缴完成结果返回
    /// </summary>
    public class GetClearTaxInfoResponseModel : AopObject
    {
        /// <summary>
        /// 清缴批次列表
        /// </summary>
        [JsonProperty("batch_list")]
        public ClearTaxData[] BatchList { get; set; }
        
    }
}