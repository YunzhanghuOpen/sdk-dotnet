using System;
using Aop.Api;
using Aop.Api.YzhCustom;
using Aop.Api.Example.Config;

namespace Aop.Api.Example
{
    /// <summary>
    /// 通用请求函数
    /// </summary>
    public class YzhCustom
    {
        /// <summary>
        /// 获取基础配置信息
        /// </summary>
        private static readonly YzhConfig Config = ConfigUtil.GetConfig();

        /// <summary>
        /// 客户端实现
        /// </summary>
        private static readonly DefaultAopClient Client = new DefaultAopClient(Config);
        public static void doRequest()
        {
            // 组装请求参数
            CustomRequestModel model = new CustomRequestModel
            {
                DealerID = Config.DealerID,
                BrokerID = Config.BrokerID,
                OrderID = "202009010016562012987",
                RealName = "张三",
                IDCard = "11010519491231002X",
                CardNo = "6228888888888888888",
                PhoneNo = "188****8888",
                Pay = "100.00",
                PayRemark = "",
                NotifyURL = "https://www.example.com",
            };

            // 配置请求信息
            CustomRequest<CustomResponseModel> request = new CustomRequest<CustomResponseModel>();
            request.SetApiPath("/api/payment/v1/order-bankpay");
            request.SetMethod("POST");
            request.SetRequestID("requestId1234567890");
            request.SetBizModel(model);

            // 发起请求
            try
            {
                CustomResponse<CustomResponseModel> res = Client.Execute(request);
                Console.WriteLine(res.Body);
                if (res.IsSuccess)
                {
                    // 操作成功
                    CustomResponseModel data = res.Data;
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

    /// <summary>
    /// 自定义请求结构体
    /// </summary>
    public class CustomRequestModel : AopObject
    {
        /// <summary>
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }

        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }

        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty("pay_remark")]
        public string PayRemark { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty("notify_url")]
        public string NotifyURL { get; set; }
    }

    /// <summary>
    /// 自定义返回结构体
    /// </summary>
    public class CustomResponseModel : AopObject
    {
        /// <summary>
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }

        /// <summary>
        /// 综合服务平台流水号
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("pay")]
        public string Pay { get; set; }
    }
}