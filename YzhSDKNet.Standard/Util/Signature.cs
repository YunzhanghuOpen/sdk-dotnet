using Aop.Api;
using Aop.Api.Util.Encryption;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Api.Util
{
    public class Signature
    {
        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="content">待签名字符串</param>
        /// <param name="type">签名类型（rsa 或 sha256）</param>
        /// <param name="appKey">App Key</param>
        /// <param name="privateKey">私钥</param>
        /// <returns>签名结果</returns>
        public static string Sign(string content, string type, string appKey, string privateKey)
        {
            try
            {
                if(string.IsNullOrEmpty(content))
                {
                    throw new AopException("待签名内容不可为 null");
                }
                IEncryptor encryptor = EncryptorManager.GetByName(type);
                return encryptor.Sign(content, appKey, privateKey);
            }
            catch (Exception ex)
            {
                string errorMsg = $"{type} 签名异常，请检查相关密钥是否正确。exMessage={ex.Message}, content={content}";
                throw new AopException(errorMsg, ex);
            }
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="content">原始字符串</param>
        /// <param name="sign">签名</param>
        /// <param name="type">签名类型（rsa 或 sha256）</param>
        /// <param name="appKey">App Key</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        public static bool Verify(string content, string sign, string type, string appKey, string publicKey)
        {
            try
            {
                if(string.IsNullOrEmpty(content))
                {
                    throw new AopException("待签名内容不可为 null");
                }

                if (string.IsNullOrEmpty(sign))
                {
                    throw new AopException("签名串内容不可为 null");
                }

                if (string.IsNullOrEmpty(appKey) && string.IsNullOrEmpty(publicKey))
                {
                    throw new AopException("签名密钥不可为空");
                }

                IEncryptor encryptor = EncryptorManager.GetByName(type);
                return encryptor.Verify(content, sign, appKey, publicKey);
            }
            catch (Exception ex)
            {
                string errorMsg = $"{type} 验签异常，请检查相关密钥是否正确。exMessage={ex.Message}, content={content}";
                throw new AopException(errorMsg, ex);
            }
        }
    }
}
