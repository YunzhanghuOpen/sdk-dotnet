using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询平台企业余额返回
    /// </summary>
    public class ListAccountResponseModel : AopObject
    {
        /// <summary>
        /// dealer_infos
        /// </summary>
        [JsonProperty("dealer_infos")]
        public AccountInfo[] DealerInfos { get; set; }

    }
}