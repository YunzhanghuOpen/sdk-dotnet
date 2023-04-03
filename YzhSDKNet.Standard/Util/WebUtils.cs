using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;

namespace Aop.Api.Util
{
    /// <summary>
    /// HTTP 请求工具类
    /// </summary>
    public sealed class WebUtils
    {
        /// <summary>
        /// 发起请求到服务端首次返回数据的超时时长，单位毫秒
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 服务端首次返回数据后，等待后续数据的超时时长，单位毫秒
        /// </summary>
        public int ReadWritTimeout { get; set; } = 15 * 1000;

        /// <summary>
        /// 自定义 HTTP 请求 Header
        /// </summary>
        public Dictionary<string, string> CustomHeaders { get; set; }

        public string DoHttpClient(string method,string url,IDictionary<string,string> parameters)
        {

            return method == HttpMethod.Post.Method ? DoPost(url, parameters) : DoGet(url, parameters);
        }

        /// <summary>
        /// 执行 HTTP POST 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP 响应</returns>
        public string DoPost(string url, IDictionary<string, string> parameters)
        {
            HttpWebRequest request = GetWebRequest(url, "POST");
            byte[] postData = Encoding.GetEncoding("UTF-8").GetBytes(BuildQuery(parameters));
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return GetResponseAsString(response);
        }

        /// <summary>
        /// 执行 HTTP GET 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP 响应</returns>
        public string DoGet(string url, IDictionary<string, string> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters);
                }
            }

            HttpWebRequest request = GetWebRequest(url, "GET");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return GetResponseAsString(response);
        }

        /// <summary>
        /// 获取请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="method">请求方式</param>
        /// <returns>请求信息</returns>
        public HttpWebRequest GetWebRequest(string url, string method)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = method;
            req.KeepAlive = true;
            req.UserAgent = string.Format("yunzhanghu-sdk-net/1.0.0/{0}/{1}/1.0.0",Environment.OSVersion.VersionString,Environment.Version);
            Console.WriteLine(req.UserAgent);
            req.Timeout = Timeout;
            req.ReadWriteTimeout = ReadWritTimeout;
            req.ContentType = "application/x-www-form-urlencoded";
            if (CustomHeaders != null && CustomHeaders.Count > 0)
            {
                foreach (var header in CustomHeaders)
                {
                    req.Headers.Add(header.Key, header.Value);
                }
            }
            return req;
        }

        /// <summary>
        /// 组装普通文本请求
        /// </summary>
        /// <param name="parameters">请求参数</param>
        /// <returns>请求文本</returns>
        public static string BuildQuery(IDictionary<string, string> parameters)
        {
            return string.Join("&", parameters.Select(p => $"{HttpUtility.UrlEncode(p.Key)}={HttpUtility.UrlEncode(p.Value)}"));
        }

        /// <summary>
        /// 把响应流转换为文本
        /// </summary>
        /// <param name="response">响应流对象</param>
        /// <returns>响应文本</returns>
        public string GetResponseAsString(HttpWebResponse response)
        {
            StringBuilder result = new StringBuilder();
            Stream stream = null;
            StreamReader reader = null;
            try
            {
                // 以字符流的方式读取响应
                stream = response.GetResponseStream();
                reader = new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet));

                // 按字符读取并写入字符串缓冲
                int ch = -1;
                while ((ch = reader.Read()) > -1)
                {
                    char c = (char)ch;
                    if (c != '\0')
                    {
                        result.Append(c);
                    }
                }
            }
            finally
            {
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (response != null) response.Close();
            }
            return result.ToString();
        }
    }
}