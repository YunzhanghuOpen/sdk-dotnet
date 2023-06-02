namespace Aop.Api
{
    /// <summary>
    /// 基础对象
    /// </summary>
    public abstract class AopObject
    {
        /// <summary>
        /// 数据是否加密返回，默认否，非所有接口均支持加密返回
        /// </summary>
        /// <returns>接口响应数据是否加密</returns>
        public virtual bool IsNeedEncrypt()
        {
            return false;
        }
    }
}
