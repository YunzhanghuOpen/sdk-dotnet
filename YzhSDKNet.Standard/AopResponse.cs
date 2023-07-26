using Newtonsoft.Json;

namespace Aop.Api
{
    /// <summary>
    /// 基础响应实体
    /// </summary>
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
            get { return this.code; }
            set { this.code = value; }
        }

        /// <summary>
        /// 响应码描述
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        /// <summary>
        /// 请求 ID
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestID
        {
            get { return this.requestID; }
            set { this.requestID = value; }
        }

        /// <summary>
        /// 响应结果原始内容
        /// </summary>
        public string Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        /// <summary>
        /// 响应结果是否报错
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return this.code.Equals("0000");
            }
        }
    }
}
