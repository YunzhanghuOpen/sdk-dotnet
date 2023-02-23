using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Api.Util.Encryption
{
    /// <summary>
    /// 加密算法接口
    /// </summary>
    public interface IEncryptor
    {

        /// <summary>
        /// 计算指定内容的签名
        /// </summary>
        /// <param name="content">待签名的原文</param>
        /// <param name="appKey">云账户分配的 App Key</param>
        /// <param name="privateKey">私钥</param>
        /// <returns>签名字符串</returns>
        string Sign(string content, string appKey, string privateKey);

        /// <summary>
        /// 验证指定内容的签名是否正确
        /// </summary>
        /// <param name="content">待校验的原文</param>
        /// <param name="sign">签名字符串</param>
        /// <param name="appKey">云账户分配的 App Key</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        bool Verify(string content, string sign, string appKey, string publicKey);
    }
}
