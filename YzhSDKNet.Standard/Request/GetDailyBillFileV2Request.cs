using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aop.Api.Response;


namespace Aop.Api.Request
{
   /// <summary>
   /// 查询日流水文件
   /// <summary>
   public class GetDailyBillFileV2Request : IAopRequest<GetDailyBillFileV2Response>
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
          return "GET";
      }

      /// <summary>
      /// 获取接口请求路由
      /// </summary>
      /// <returns>响应接口请求路由</returns>
      public string GetApiPath()
      {
          return "/api/dataservice/v2/bill/downloadurl";
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
          var st = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
          return Convert.ToInt64(st.TotalSeconds).ToString();
      }

      #endregion
   }
}