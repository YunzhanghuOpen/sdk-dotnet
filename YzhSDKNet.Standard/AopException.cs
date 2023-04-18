using System;
using System.Runtime.Serialization;

namespace Aop.Api
{
    /// <summary>
    /// Aop 客户端异常
    /// </summary>
    public class AopException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AopException"/> class.
        /// </summary>
        public AopException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AopException"/> class.
        /// </summary>
        /// <param name="message">具体错误信息</param>
        public AopException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AopException"/> class.
        /// </summary>
        /// <param name="info">序列化后的信息</param>
        /// <param name="context">源信息</param>
        protected AopException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AopException"/> class.
        /// </summary>
        /// <param name="message">错误信息</param>
        /// <param name="innerException">内部异常</param>
        public AopException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// 错误码
        /// </summary>
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        public string ErrMsg { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AopException"/> class.
        /// </summary>
        /// <param name="errCode">错误码</param>
        /// <param name="errMsg">错误描述</param>
        public AopException(string errCode, string errMsg)
            : base(errCode + ":" + errMsg)
        {
            this.ErrCode = errCode;
            this.ErrMsg = errMsg;
        }
    }
}
