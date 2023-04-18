namespace Aop.Api
{
    /// <summary>
    /// Aop 请求接口
    /// </summary>
    /// <typeparam name="T">响应数据类型</typeparam>
    public interface IAopRequest<T>
        where T : AopResponse
    {
        /// <summary>
        /// 设置请求 ID
        /// </summary>
        /// <param name="requestID">请求 ID</param>
        void SetRequestID(string requestID);

        /// <summary>
        /// 获取请求 ID
        /// </summary>
        /// <returns>响应请求 ID</returns>
        string GetRequestID();

        /// <summary>
        /// 设置随机数
        /// </summary>
        void SetMess(string mess);

        /// <summary>
        /// 获取随机数
        /// </summary>
        /// <returns>随机数</returns>
        string GetMess();

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns>时间戳，精确到秒</returns>
        string GetTimestamp();

        /// <summary>
        /// 获取接口请求类型
        /// </summary>
        /// <returns>接口请求类型 GET OR POST</returns>
        string GetMethod();

        /// <summary>
        /// 获取接口请求路由
        /// </summary>
        /// <returns>响应接口请求路由</returns>
        string GetApiPath();

        /// <summary>
        /// 获取接口请求业务参数实体
        /// </summary>
        /// <returns>业务参数</returns>
        AopObject GetBizModel();

        /// <summary>
        /// 设置接口请求业务参数
        /// </summary>
        /// <param name="bizModel">业务参数</param>
        void SetBizModel(AopObject bizModel);
    }
}
