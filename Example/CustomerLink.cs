using System;
using Aop.Api;
using Aop.Api.Example.Config;
using Aop.Api.Util;

namespace Aop.Api.Example
{
    public class CustomerLinkExample
    {
        /// <summary>
        /// 专属客服链接管理
        /// </summary>
        public static void GetCustomerLinkUrl()
        {
            YzhConfig config = ConfigUtil.GetConfig();
            string baseUrl = "https://www.example.com";
            string memberId = "Test123456";
            string customerLinkUrl = CustomerLinkUtil.getCustomerLink(Config, baseUrl, memberId);
            Console.WriteLine(customerLinkUrl);
        }
    }
}
