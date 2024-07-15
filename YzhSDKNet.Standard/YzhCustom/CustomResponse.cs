using Newtonsoft.Json;

namespace Aop.Api.YzhCustom
{
    /// <summary>
    /// 通用请求函数返回基础结构体
    /// </summary>
    /// <typeparam name="T">返回结构体类型</typeparam>
    public class CustomResponse<T> : AopResponse
    {
        [JsonProperty("data")]
        public T Data { get; set; }
        
    }
}