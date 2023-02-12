using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Aop.Api
{
    /// <summary>
    /// Aop 客户端异常
    /// </summary>
    public class AopException : Exception
    {
        public AopException()
        {
        }

        public AopException(string message) : base(message)
        {
        }

        protected AopException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public AopException(string message, Exception innerException) : base(message, innerException)
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

        public AopException(string errCode, string errMsg) : base(errCode + ":" + errMsg)
        {
            ErrCode = errCode;
            ErrMsg = errMsg;
        }
    }
}
