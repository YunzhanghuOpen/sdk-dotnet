using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Aop.Api.Util.Encryption
{
    /// <summary>
    /// RSA 签名实现
    /// </summary>
    public class RSAEncryptor : IEncryptor
    {
        /// <summary>
        /// 计算指定内容的签名
        /// </summary>
        /// <param name="content">待签名的原文</param>
        /// <param name="appKey">云账户 App Key</param>
        /// <param name="privateKey">平台企业私钥</param>
        /// <returns>签名结果</returns>
        public string Sign(string content, string appKey, string privateKey)
        {
            using (RSACryptoServiceProvider rsaService = this.BuildRSAServiceProvider(privateKey))
            {
                byte[] data = Encoding.UTF8.GetBytes(content);
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                byte[] sign = rsaService.SignData(data, sha256);
                return Convert.ToBase64String(sign);
            }
        }

        /// <summary>
        /// 验证指定内容的签名是否正确
        /// </summary>
        /// <param name="content">待验签的原文</param>
        /// <param name="sign">签名结果</param>
        /// <param name="appKey">云账户 App Key</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        public bool Verify(string content, string sign, string appKey, string publicKey)
        {
            using (RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider())
            {
                rsaService.PersistKeyInCsp = false;
                rsaService.ImportParameters(this.ConvertFromPemPublicKey(publicKey));
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                return rsaService.VerifyData(Encoding.UTF8.GetBytes(content), sha256, Convert.FromBase64String(sign));
            }
        }

        // 加载公钥
        private RSAParameters ConvertFromPemPublicKey(string pemPublicKey)
        {
            if (string.IsNullOrEmpty(pemPublicKey))
            {
                throw new AopException("云账户公钥，不可为空。");
            }

            // 移除干扰文本
            pemPublicKey = pemPublicKey.Replace("-----BEGIN PUBLIC KEY-----", string.Empty)
                .Replace("-----END PUBLIC KEY-----", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Trim();

            byte[] keyData = Convert.FromBase64String(pemPublicKey);
            bool keySize1024 = keyData.Length == 162;
            bool keySize2048 = keyData.Length == 294;
            if (!(keySize1024 || keySize2048))
            {
                throw new AopException("公钥长度只支持 1024 或 2048。");
            }

            byte[] pemModulus = keySize1024 ? new byte[128] : new byte[256];
            byte[] pemPublicExponent = new byte[3];
            Array.Copy(keyData, keySize1024 ? 29 : 33, pemModulus, 0, keySize1024 ? 128 : 256);
            Array.Copy(keyData, keySize1024 ? 159 : 291, pemPublicExponent, 0, 3);
            RSAParameters para = new RSAParameters
            {
                Modulus = pemModulus,
                Exponent = pemPublicExponent,
            };
            return para;
        }

        // 加载私钥
        private RSACryptoServiceProvider BuildRSAServiceProvider(string privateKey)
        {
            privateKey = privateKey.Replace("-----BEGIN RSA PRIVATE KEY-----", string.Empty)
         .Replace("-----END RSA PRIVATE KEY-----", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Trim();

            byte[] keyData = Convert.FromBase64String(privateKey);

            byte[] mODULUS, e, d, p, q, dP, dQ, iQ;
            byte bt = 0;
            ushort twobytes = 0;
            int elems = 0;

            using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(keyData)))
            {
                twobytes = binaryReader.ReadUInt16();

                if (twobytes == 0x8130)
                {
                    binaryReader.ReadByte();
                }
                else if (twobytes == 0x8230)
                {
                    binaryReader.ReadInt16();
                }
                else
                {
                    return null;
                }

                twobytes = binaryReader.ReadUInt16();

                if (twobytes != 0x0102)
                {
                    return null;
                }

                bt = binaryReader.ReadByte();
                if (bt != 0x00)
                {
                    return null;
                }

                elems = GetIntegerSize(binaryReader);
                mODULUS = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                e = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                d = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                p = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                q = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                dP = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                dQ = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                iQ = binaryReader.ReadBytes(elems);

                RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider();
                RSAParameters rsaParams = new RSAParameters
                {
                    Modulus = mODULUS,
                    Exponent = e,
                    D = d,
                    P = p,
                    Q = q,
                    DP = dP,
                    DQ = dQ,
                    InverseQ = iQ,
                };
                rsaService.ImportParameters(rsaParams);
                return rsaService;
            }
        }

        private static int GetIntegerSize(BinaryReader binaryReader)
        {
            byte bt = 0;
            byte lowbyte = 0x00;
            byte highbyte = 0x00;
            int count = 0;

            bt = binaryReader.ReadByte();

            if (bt != 0x02)
            {
                return 0;
            }
            bt = binaryReader.ReadByte();

            if (bt == 0x81)
            {
                count = binaryReader.ReadByte();
            }
            else if (bt == 0x82)
            {
                highbyte = binaryReader.ReadByte();
                lowbyte = binaryReader.ReadByte();
                byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                count = BitConverter.ToInt32(modint, 0);
            }
            else
            {
                count = bt;
            }

            while (binaryReader.ReadByte() == 0x00)
            {
                count -= 1;
            }

            binaryReader.BaseStream.Seek(-1, SeekOrigin.Current);
            return count;
        }
    }
}
