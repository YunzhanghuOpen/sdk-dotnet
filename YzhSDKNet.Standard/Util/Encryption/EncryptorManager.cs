namespace Aop.Api.Util.Encryption
{
    /// <summary>
    /// 签名算法管理类
    /// </summary>
    public static class EncryptorManager
    {
        /// <summary>
        /// 根据算法名称（rsa、sha256）实例化具体的算法加密器
        /// </summary>
        /// <param name="type">签名方式</param>
        /// <returns>类型对应签名实例</returns>
        public static IEncryptor GetByName(string type)
        {
            if (type.ToLower().Equals("rsa"))
            {
                return new RSAEncryptor();
            }

            if (type.ToLower().Equals("sha256"))
            {
                return new HMACEncryptor();
            }

            throw new AopException($"无效的签名方式：[{type}]，可选值为：rsa、sha256");
        }
    }
}
