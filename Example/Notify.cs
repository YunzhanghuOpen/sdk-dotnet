using System;
using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Example.config;

namespace Aop.Api.Example
{
    /// <summary>
    /// API签约
    /// </summary>
    public class ApiUserSign
    {
        // 获取基础配置信息
        static YzhConfig config = ConfigUtil.GetConfig();
        // 客户端实现
        static DefaultAopClient client = new DefaultAopClient(config);

        // 订单回调验签解密
        public static void NotifyOrderData_Example()
        {
            // 实例化具体 API 对应的 request 类
            YzhCallbackRequest<NotifyOrderRequestModel> request = new YzhCallbackRequest<NotifyOrderRequestModel>()
            {
                Data = "",
                Mess = "",
                Timestamp = "",
                Sign = "",
                SignType = ""
            };

            // 发起请求
            NotifyOrderRequestModel res = client.CallBackExecute(request);

            Console.WriteLine(res.Body);

            NotifyOrderData data = res.Data;

            //根据接收到的数据进行后续业务处理
            switch (data.Status)
            {
                case "1":
                    // 已支付（对于支付宝和微信支付是最终状态，对于银行卡大部分情况是终态，小概率会出现“退汇现象”，状态由“成功”变为“退汇”）
                    // TODO 更新业务订单状态,提示用户提现成功
                    break;
                case "2":
                    // 失败（最终状态）
                    // TODO 更新业务订单状态,提示用户提现失败，若有用户钱包体系，则需将提现金额退回至用户钱包
                    break;
                case "4":
                    // 订单挂起（中间状态，挂起原因会在订单详细状态信息返回）
                    // TODO 提示用户提现中，其他逻辑如：若因余额不足导致的订单挂起，可通知财务及时预付业务服务费，72 小时内补足余额后可自动继续支付，切勿将订单挂起当做失败处理
                    break;
                case "9":
                    // 退汇失败（最终状态，银行卡支付路径特有现象，收到“成功”回调后，再收到“退汇”的回调，一般与成功状态间隔 24 小时以上）
                    // TODO 更新业务订单状态为“退汇”（失败），通知用户提现失败，建议用户更换其他银行卡提现，若有用户钱包体系，则需将提现金额退回至用户钱包
                    break;
                case "15":
                    // 订单取消（最终状态，只有订单挂起的订单才可以取消）
                    // TODO 更新业务订单状态为“取消”（失败，通知用户提现失败，若有用户钱包体系，则需将提现金额退回至用户钱包
                    break;
            }
        }
    }
}


