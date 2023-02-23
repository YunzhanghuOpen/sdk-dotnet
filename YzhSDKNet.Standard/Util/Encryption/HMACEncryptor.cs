using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Aop.Api.Util.Encryption
{
    /// <summary>
    /// HMAC 签名实现
    /// </summary>
    public class HMACEncryptor : IEncryptor
    {
        /// <summary>
        /// 计算指定内容的签名
        /// </summary>
        /// <param name="content">待签名的原文</param>
        /// <param name="appKey">云账户分配的 App Key</param>
        /// <param name="privateKey">私钥</param>
        /// <returns>签名字符串</returns>
        public string Sign(string content, string appKey, string privateKey)
        {
            var encoding = Encoding.UTF8;
            byte[] dataByte = encoding.GetBytes(content);
            byte[] keyByte = encoding.GetBytes(appKey);
            using (var hmac = new HMACSHA256(keyByte))
            {
                byte[] hashByte = hmac.ComputeHash(dataByte);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashByte.Length; i++)
                {
                    builder.Append(hashByte[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// 验证指定内容的签名是否正确
        /// </summary>
        /// <param name="content">待校验的原文</param>
        /// <param name="sign">签名字符串</param>
        /// <param name="appKey">云账户分配的 App Key</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        public bool Verify(string content, string sign, string appKey, string publicKey)
        {
            string newSign = Sign(content, appKey, publicKey);
            return sign == newSign;
        }
    }
}
