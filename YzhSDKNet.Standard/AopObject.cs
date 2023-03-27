using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Api
{
    /// <summary>
    /// 基础对象
    /// </summary>
    public abstract class AopObject
    {
        private string body;
        /// <summary>
        /// 请求原始内容
        /// </summary>
        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        /// <summary>
        /// 数据是否加密返回，默认否，非所有接口均支持加密返回
        /// </summary>
        /// <returns>接口响应数据是否加密</returns>
        public virtual bool GetNeedEncrypt()
        {
            return false;
        }
    }
}
