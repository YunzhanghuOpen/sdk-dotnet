using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Api
{
    public abstract class AopResponse
    {
        private string code;
        private string message;
        private string requestID;
        private string body;


        /// <summary>
        /// 响应码
        /// </summary>
        [JsonProperty("code")]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// 响应文案
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        /// <summary>
        /// 响应结果是否报错
        /// </summary>
        public bool IsError
        {
            get
            {
                return code.Equals("0000");
            }
        }

    }
}
