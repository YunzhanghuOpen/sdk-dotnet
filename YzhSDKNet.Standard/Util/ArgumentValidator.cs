using Aop.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Api.Util
{
    /// <summary>
    /// 参数校验类
    /// </summary>
    public class ArgumentValidator
    {
        public static void CheckArgument(bool expression, string errorMessage)
        {
            if (expression)
            {
                throw new AopException(errorMessage);
            }
        }

        public static void CheckNotNull(string value, string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new AopException(errorMessage);
            }
        }
    }
}
