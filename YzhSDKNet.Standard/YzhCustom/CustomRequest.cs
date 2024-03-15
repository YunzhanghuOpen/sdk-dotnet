using System;
using Aop.Api.Util;

namespace Aop.Api.YzhCustom
{
    /// <summary>
    /// 通用请求函数请求基础结构体
    /// </summary>
    /// <typeparam name="T">返回结构体类型</typeparam>
    public class CustomRequest<T> : IAopRequest<CustomResponse<T>>
    {
        private string mess;
        private string requestID;
        private AopObject bizModel;
        private string method;
        private string apiPath;

        /// <summary>
        /// 获取接口请求业务参数
        /// </summary>
        /// <returns>响应接口请求业务参数</returns>
        public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        /// <summary>
        /// 设置接口请求业务参数
        /// </summary>
        /// <param name="bizModel">业务参数</param>
        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        /// <summary>
        /// 设置接口请求方式
        /// </summary>
        /// <param name="method">接口请求方式</param>
        public void SetMethod(string method)
        {
            if ("GET".Equals(method.ToUpper()))
            {
                this.method = method;
            }
            else
            {
                this.method = "POST";
            }
        }

        /// <summary>
        /// 获取接口请求方式
        /// </summary>
        /// <returns>响应接口请求方式</returns>
        public string GetMethod()
        {
            return this.method;
        }

        /// <summary>
        /// 设置接口请求地址
        /// </summary>
        /// <param name="apiPath">接口请求地址</param>
        public void SetApiPath(string apiPath)
        {
            if (string.IsNullOrEmpty(apiPath))
            {
                throw new AopException("接口请求地址不能为空");
            }

            this.apiPath = apiPath;
        }

        /// <summary>
        /// 获取接口请求地址
        /// </summary>
        /// <returns>响应接口请求地址</returns>
        public string GetApiPath()
        {
            return this.apiPath;
        }

        /// <summary>
        /// 获取随机数
        /// </summary>
        /// <returns>随机数，未设置时使用 GUID 方法自动生成</returns>
        public string GetMess()
        {
            if (string.IsNullOrEmpty(this.mess))
            {
                return Guid.NewGuid().ToString();
            }

            return this.mess;
        }

        /// <summary>
        /// 设置随机数
        /// </summary>
        /// <param name="mess">随机数</param>
        public void SetMess(string mess)
        {
            this.mess = mess;
        }

        /// <summary>
        /// 获取请求 ID
        /// </summary>
        /// <returns>请求 ID，未设置时使用 GUID 方法自动生成</returns>
        public string GetRequestID()
        {
            if (string.IsNullOrEmpty(this.requestID))
            {
                return Guid.NewGuid().ToString();
            }

            return this.requestID;
        }

        /// <summary>
        /// 设置请求 ID
        /// </summary>
        /// <param name="requestID">请求 ID</param>
        public void SetRequestID(string requestID)
        {
            this.requestID = requestID;
        }

        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <returns>时间戳，精确到秒</returns>
        public string GetTimestamp()
        {
            return WebUtils.GetTimestamp();
        }
    }
}
