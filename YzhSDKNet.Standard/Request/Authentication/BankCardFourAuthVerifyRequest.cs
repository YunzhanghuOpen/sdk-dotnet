using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
   /// <summary>
   /// 银行卡四要素鉴权请求（下发短信验证码）
   /// <summary>
   public class BankCardFourAuthVerifyRequest : IAopRequest<BankCardFourAuthVerifyResponse>
   {
      #region IAopRequest Members
      private string mess;
      private string requestID;
      private AopObject bizModel;

      /// <summary>
      /// 获取接口请求业务参数
      /// </summary>
      /// <returns>响应接口请求业务参数</returns>
      public AopObject GetBizModel()
      {
          return this.bizModel;
      }

      /// <summary>
      /// 设置接口请求业务参数
      /// </summary>
      /// <param name="bizModel">业务参数</param>
      /// <returns></returns>
      public void SetBizModel(AopObject bizModel)
      {
          this.bizModel = bizModel;
      }

      /// <summary>
      /// 获取接口请求类型
      /// </summary>
      /// <returns>响应接口请求类型</returns>
      public string GetMethod()
      {
          return "POST";
      }

      /// <summary>
      /// 获取接口请求路由
      /// </summary>
      /// <returns>响应接口请求路由</returns>
      public string GetApiPath()
      {
          return "/authentication/verify-request";
      }

      /// <summary>
      /// 获取随机数
      /// </summary>
      /// <returns>随机数，未设置时默认生成</returns>
      public string GetMess()
      {
          if (string.IsNullOrEmpty(this.mess))
          {
              return Guid.NewGuid().ToString();
          }
          return mess;
      }

      /// <summary>
      /// 设置随机数
      /// </summary>
      /// <param name="mess">随机数</param>
      public void SetMess(string mess)
      {
          this.mess = mess;
      }

      /// <summary>
      /// 获取请求 ID
      /// </summary>
      /// <returns>请求 ID，未设置时返回默认</returns>
      public string GetRequestID()
      {
          if (string.IsNullOrEmpty(this.requestID))
          {
              return Guid.NewGuid().ToString();
          }
          return this.requestID;
      }

      /// <summary>
      /// 设置请求 ID
      /// </summary>
      /// <param name="requestID">请求 ID</param>
      public void SetRequestID(string requestID)
      {
          this.requestID = requestID;
      }

      /// <summary>
      /// 获取当前时间戳
      /// </summary>
      /// <returns>时间戳，精确到秒</returns>
      public string GetTimestamp()
      {
          return WebUtils.GetTimestamp();
      }

      #endregion
   }
}