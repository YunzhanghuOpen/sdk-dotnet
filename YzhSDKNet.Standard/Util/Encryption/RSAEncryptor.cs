using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Aop.Api.Util.Encryption
{
    /// <summary>
    /// rsa 签名实现
    /// </summary>
    public class RSAEncryptor : IEncryptor
    {
        /// <summary>
        /// 计算指定内容的签名
        /// </summary>
        /// <param name="content">待签名的原文</param>
        /// <param name="appKey">云账户分配的 App Key</param>
        /// <param name="key">私钥</param>
        /// <returns>签名字符串</returns>
        public string Sign(string content, string appKey, string privateKey)
        {
            using (RSACryptoServiceProvider rsaService = BuildRSAServiceProvider(privateKey))
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
        /// <param name="content">待校验的原文</param>
        /// <param name="sign">签名字符串</param>
        /// <param name="appKey">云账户分配的 App Key</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        public bool Verify(string content, string sign, string appKey, string publicKey)
        {
            using (RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider())
            {
                rsaService.PersistKeyInCsp = false;
                rsaService.ImportParameters(ConvertFromPemPublicKey(publicKey));
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                return rsaService.VerifyData(Encoding.UTF8.GetBytes(content), sha256, Convert.FromBase64String(sign));
            }
        }

        //加载公钥
        private RSAParameters ConvertFromPemPublicKey(string pemPublickKey)
        {
            if (string.IsNullOrEmpty(pemPublickKey))
            {
                throw new AopException("PEM 格式公钥，不可为空。");
            }

            // 移除干扰文本
            pemPublickKey = pemPublickKey.Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "").Replace("\n", "").Replace("\r", "");

            byte[] keyData = Convert.FromBase64String(pemPublickKey);
            bool keySize1024 = keyData.Length == 162;
            bool keySize2048 = keyData.Length == 294;
            if (!(keySize1024 || keySize2048))
            {
                throw new AopException("公钥长度只支持 1024 和 2048。");
            }
            byte[] pemModulus = keySize1024 ? new byte[128] : new byte[256];
            byte[] pemPublicExponent = new byte[3];
            Array.Copy(keyData, keySize1024 ? 29 : 33, pemModulus, 0, keySize1024 ? 128 : 256);
            Array.Copy(keyData, keySize1024 ? 159 : 291, pemPublicExponent, 0, 3);
            RSAParameters para = new RSAParameters();
            para.Modulus = pemModulus;
            para.Exponent = pemPublicExponent;
            return para;
        }

        //加载私钥
        private RSACryptoServiceProvider BuildRSAServiceProvider(string privateKey)
        {
            privateKey = privateKey.Replace("-----BEGIN RSA PRIVATE KEY-----", "")
         .Replace("-----END RSA PRIVATE KEY-----", "").Replace("\n", "").Replace("\r", "").Trim();

            byte[] keyData = Convert.FromBase64String(privateKey);

            byte[] MODULUS, E, D, P, Q, DP, DQ, IQ;
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
                MODULUS = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                E = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                D = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                P = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                Q = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                DP = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                DQ = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                IQ = binaryReader.ReadBytes(elems);

                
                RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider();
                RSAParameters rsaParams = new RSAParameters
                {
                    Modulus = MODULUS,
                    Exponent = E,
                    D = D,
                    P = P,
                    Q = Q,
                    DP = DP,
                    DQ = DQ,
                    InverseQ = IQ
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
