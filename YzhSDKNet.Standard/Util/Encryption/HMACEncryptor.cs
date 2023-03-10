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
        /// <param name="appKey">云账户 App Key</param>
        /// <param name="privateKey">私钥，不需要传输</param>
        /// <returns>签名结果</returns>
        public string Sign(string content, string appKey, string privateKey)
        {
            return Sign(content, appKey);
        }

        /// <summary>
        /// 验证指定内容的签名是否正确
        /// </summary>
        /// <param name="content">待验签的原文</param>
        /// <param name="sign">签名结果</param>
        /// <param name="appKey">云账户 App Key</param>
        /// <param name="publicKey">公钥，不需要传输</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        public bool Verify(string content, string sign, string appKey, string publicKey)
        {
            string newSign = Sign(content, appKey);
            return sign == newSign;
        }

        /// <summary>
        /// 计算签名
        /// </summary>
        /// <param name="content">待签名原文</param>
        /// <param name="appKey">云账户 App Key</param>
        /// <returns>签名结果</returns>
        private string Sign(string content,string appKey)
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
    }
}
