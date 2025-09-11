using System;
using System.Web;

namespace Aop.Api.Util
{
    public class CustomerLinkUtil
    {

        /// <summary>
        /// 专属客服链接管理
        /// </summary>
        /// <param name="config">密钥信息</param>
        /// <param name="baseUrl">客服链接基础地址</param>
        /// <param name="memberId">用户 ID</param>
        /// <returns>客服链接</returns>
        public static string getCustomerLink(YzhConfig config, string baseUrl, string memberId)
        {
            return GetLinkUrl(config, baseUrl, memberId);
        }

        private static string GetLinkUrl(YzhConfig config, string baseUrl, string memberId)
        {
            string mess = Guid.NewGuid().ToString();
            string timestamp = WebUtils.GetTimestamp();
            string sign = Signer(config, memberId, mess, timestamp);
            string url = $"{baseUrl}?sign_type={config.SignType}&sign={HttpUtility.UrlEncode(sign)}&member_id={memberId}&mess={mess}&timestamp={timestamp}";
            return url;
        }

        private static string Signer(YzhConfig config, string memberId, string mess, string timestamp)
        {
            string plain = $"data=member_id={memberId}&mess={mess}&timestamp={timestamp}&key={config.AppKey}";
            string sign = Signature.Sign(plain, config.SignType, config.AppKey, config.PrivateKey);
            return sign;
        }
    }
}
