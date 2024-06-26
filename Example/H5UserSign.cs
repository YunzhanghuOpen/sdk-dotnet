﻿using System;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 用户签约（H5 签约）
    /// </summary>
    public class H5UserSign
    {
        /// <summary>
        /// 获取基础配置信息
        /// </summary>
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        /// <summary>
        /// 客户端实现
        /// </summary>
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);

        /// <summary>
        /// 预申请签约
        /// </summary>
        public static void H5UserPresign()
        {
            // 实例化具体 API 对应的 request 类
            H5UserPresignRequest request = new H5UserPresignRequest();

            // 配置请求参数
            H5UserPresignRequestModel model = new H5UserPresignRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "11010519491231002X",
                CertificateType = 0,
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5UserPresignResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    H5UserPresignResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 申请签约
        /// </summary>
        public static void UserSign()
        {
            // 实例化具体 API 对应的 request 类
            H5UserSignRequest request = new H5UserSignRequest();

            // 配置请求参数
            H5UserSignRequestModel model = new H5UserSignRequestModel
            {
                Token = "1231231jdfalrejia",
                Color = "#8171ff",
                URL = "https://www.example.com",
                RedirectURL = "https://www.example.com",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5UserSignResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    H5UserSignResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 获取用户签约状态
        /// </summary>
        public static void GeH5UserSignStatus()
        {
            // 实例化具体 API 对应的 request 类
            GetH5UserSignStatusRequest request = new GetH5UserSignStatusRequest();

            // 配置请求参数
            GetH5UserSignStatusRequestModel model = new GetH5UserSignStatusRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "11010519491231002X",
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                GetH5UserSignStatusResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    GetH5UserSignStatusResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 用户解约（测试账号专用）
        /// </summary>
        public static void H5UserRelease()
        {
            // 实例化具体 API 对应的 request 类
            H5UserReleaseRequest request = new H5UserReleaseRequest();

            // 配置请求参数
            H5UserReleaseRequestModel model = new H5UserReleaseRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                RealName = "张三",
                IDCard = "11010519491231002X",
                CertificateType = 0,
            };
            request.SetBizModel(model);

            // request-id：请求 ID，请求的唯一标识
            // 建议平台企业自定义 request-id，并记录在日志中。如遇异常请求，便于问题发现及排查
            // 如未自定义 request-id，将使用 SDK 中的 GUID 方法自动生成。注意：GUID 方法生成的 request-id 不能保证全局唯一，推荐自定义 request-id
            // request.SetRequestID("");

            // 发起请求
            try
            {
                H5UserReleaseResponse res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    H5UserReleaseResponseModel data = res.Data;
                }
                else
                {
                    // 失败返回
                    Console.WriteLine("失败返回");
                }
            }
            catch (Exception e)
            {
                // 发生异常
                Console.WriteLine(e);
            }
        }
    }
}
