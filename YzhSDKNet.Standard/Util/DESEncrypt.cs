﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Aop.Api.Util
{
    /// <summary>
    /// 3DES 加解密
    /// </summary>
    public static class DESEncrypt
    {
        /// <summary>
        /// 3DES 加密
        /// </summary>
        /// <param name="plainText">明文数据</param>
        /// <param name="desKey">3DES Key</param>
        /// <returns>加密数据</returns>
        public static string Encrypt(string plainText, string desKey)
        {
            var des = new TripleDESCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(desKey),
                Mode = CipherMode.CBC,
                IV = Encoding.UTF8.GetBytes(desKey.Substring(0, 8)),
            };

            var encryptor = des.CreateEncryptor();
            byte[] buffer = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
        }

        /// <summary>
        /// 3DES 解密
        /// </summary>
        /// <param name="cipherTextBase64">加密数据</param>
        /// <param name="desKey">3DES Key</param>
        /// <returns>明文数据</returns>
        public static string Decrypt(string cipherTextBase64, string desKey)
        {
            var des = new TripleDESCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(desKey),
                Mode = CipherMode.CBC,
                IV = Encoding.UTF8.GetBytes(desKey.Substring(0, 8)),
            };

            var decryptor = des.CreateDecryptor();
            byte[] buffer = Convert.FromBase64String(cipherTextBase64);
            return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(buffer, 0, buffer.Length));
        }
    }
}
