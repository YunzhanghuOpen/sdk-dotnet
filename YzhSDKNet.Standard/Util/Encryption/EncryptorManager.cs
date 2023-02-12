using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Api.Util.Encryption
{
    /// <summary>
    /// 签名算法管理类
    /// </summary>
    public static class EncryptorManager
    {
        /// <summary>
        /// 根据算法名称（RSA、SHA256）实例化具体的算法加密器
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="AopException"></exception>
        public static IEncryptor GetByName(string type)
        {
            if (type.Equals("RSA"))
            {
                return new RSAEncryptor();
            }

            if (type.Equals("SHA256"))
            {
                return new HMACEncryptor();
            }

            throw new AopException($"无效的签名类型：[{type}]，可选值为：RSA、SHA256");
        }
    }
}
