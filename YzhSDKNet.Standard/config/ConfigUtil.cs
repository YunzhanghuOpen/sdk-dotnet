using System;


namespace Aop.Api.config
{
    public class ConfigUtil
    {
        // 获取基础配置信息
        public static YzhConfig GetConfig()
        {
            YzhConfig config = new YzhConfig();
            config.ServerUrl = "https://api-aic.yunzhanghu.com"; // 设置基础接口地址
            config.DealerID = "25331815"; // 设置平台企业 ID
            config.BrokerID = "27532644"; // 设置综合服务主体 ID
            config.AppKey = "0gyU31LaiFfZRrfqq3UZiUl7JVk516ES"; // 设置 App Key
            config.PrivateKey = @"MIIEpAIBAAKCAQEAwAmXEiyxRfCl9vy/maOXALFMbhXY9VwRybyfKa+Y5TPGFyqH
DR3MDGxuXxZf/uR1uNbJKp7QS5fSFx5DvUIS+4wYdUbzoNtliu4r81iht2Xl93GH
wif6tht2CKJuaWI5LBoZKlGij3K7mIQnCYueXhzzTIqr8U9wNh5rgxx2vxO04EE4
gvbubce2jXCzcc/dDgutjwVA2/WfKerGph+Xh4p2KaZRxvJ9YyV+ll4pjsR1V0Vu
QuW55HgqDHJ8pS2JFqTGHJO417BRBd6rvIJLY14Jo/B3N7F3Jubmg8Gt4SMLMAEC
RiVlKRz7p7ho5IU0SzN7iip9jVUi8HRrn7GY+wIDAQABAoIBAQCuFkOIa1GNOLoL
bFb5Ha7fJttFlLKowv0xJ7gV3yS46zVxfNEPF+sJfCaWNr9xX4REuxmEdJIZZRlE
ceAwqrxwozDs6BQlx56G0qCvKrL3gf12UsoiPYHvInffHfj/udZgX4xeq8C1T+o2
Od71rUc0xAPfaHq0+DGeLfeC1QPk9JFtGxfuOrztdvvuz5F1grQeVzRGBwVPW6d1
DcW+vBzXHGq3jl5FXJzB2dLtui7cP2QIF6MCZWFZcUvSQEG75BAvf4Lte3hCGyF8
zlmYXqZK7ng5z0SrAPYZF020T23OLgIdiEl+Zvbc6o04rl2hdw6Lzrl7+NDj4p0M
XX6opeTBAoGBAPTzH0B/wvtxBmUGA6O2CcBCD1dJ/T8wFlRGUDHQ2IM7WPfmxaZC
eIH7d0zou+ianuwXvk0fCKTsK7i3w+BWua6Y7wFmdU1h4EzN5ax6LCVmVhSkeHyI
2bU3ruBSNI/I4oXVgGyRDcSbhASXDbmpLfWwTd1bHZrmZlOzL4njoeihAoGBAMiz
ZQU9WXvgxM+zY2QW/EGZeX80LpQ1hbbXxlTITutL/neYazm9imcrlcji2VvK2kvK
pghtk04NMtinM+d5yehTIVBmRZ+1T+dvXXexDwR2Tta+U/D4KnAENvcOzZv+7LtW
loe+TYowqgyvvhy+sllWpn6eG7wSJXkuRYLClBAbAoGACIWMyMmpFuZPuqQC7Gcg
37dsoTTJwrEBldz8XT9OyQH/jmBQ7//QAXWmKN7P6r+2V7BbxoMV4eb1fm+mON/L
he98IShXXGHTU9i17NIzRvnQdNdj+bEpIczWIKe7fGUYvF85II3LVNO0PBSlPZhN
KQcBLnpFBWaOmMrbFIj+0QECgYEArLdtdT/hlTDOTmvzWbxKI+3+19BBUXxp8Prq
DCZBfE5u098QT6VkyPqCMVm/cjY0/EqN7ezWerHzEu15RnfRoSSBI96PhiyTcfit
uAZghReHK1iphlMaukF2R9CuctPESEfwzSqhMg5FGRvYgIY/l5BxQb+w4H3BT/LZ
EPmAUAcCgYB4jNVz2L1zz1vyxyRNS0fsH6DMWKfevz7F238TsHuX2h7fkA3hTsdq
EjhluP2ggw2n+KA1aqq+oxKq7M2WdGnXu5mJVuudrXf3/b8SMz1LKHgBFfA+ZYMJ
3Sis9oLP7Re27j/3a5gMdzSmLz9hFUm7lohs0V/5zVLIPv0SgkeepA=="; // 设置平台企业私钥
            config.YzhPublicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDM8TIYAVN+xwvTyNOttvt+rVGo
Ky0L34nVq4mPouOmRD8UyqpZvXq/bE+Fdl07jvn4u7hRkOk8V1q+zDwCei1rs0T3
FcAhRlzk00vuE/BxE+KvoIyor9epZjn+3/0Y/u+tp1WJHXFF/6K/DpxThbmoTR5s
bSPGVxNMgAMmu6PVLQIDAQAB
-----END PUBLIC KEY-----"; // 设置云账户公钥
            config.Des3Key = "Isg2WsfdbyM4Dt6sJ1yzx6iP"; // 设置 3DES Key
            config.SignType = "rsa"; // 设置签名方式，rsa 或 sha256

            return config;

        }
    }
}
