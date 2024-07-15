using Newtonsoft.Json;
using Aop.Api.Domain;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// 查询平台企业预付业务服务费记录
    /// </summary>
    public class ListDealerRechargeRecordV2Response : AopResponse
    {
        /// <summary>
        /// 查询平台企业预付业务服务费记录
        /// </summary>
        [JsonProperty("data")]
        public List<RechargeRecordInfo> Data { get; set; }
        
    }
}