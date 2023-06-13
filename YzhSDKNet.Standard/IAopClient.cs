namespace Aop.Api
{
    /// <summary>
    /// AOP 客户端
    /// </summary>
    public interface IAopClient
    {
        /// <summary>
        /// 调用 OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <returns>响应参数对象</returns>
        T Execute<T>(IAopRequest<T> request)
            where T : AopResponse;
    }
}
