using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Aop.Api.Util
{
    /// <summary>
    /// HTTP 请求工具类
    /// </summary>
    public sealed class WebUtils
    {
        /// <summary>
        /// 发起请求到服务端首次返回数据的超时时间，单位：毫秒
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 服务端首次返回数据后，等待后续数据的超时时间，单位：毫秒
        /// </summary>
        public int ReadWritTimeout { get; set; } = 15 * 1000;

        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <returns>时间戳，精确到秒</returns>
        public static string GetTimestamp()
        {
            var st = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(st.TotalSeconds).ToString();
        }

        /// <summary>
        /// 自定义 HTTP 请求 Header
        /// </summary>
        public Dictionary<string, string> CustomHeaders { get; set; }

        /// <summary>
        /// 使用 HTTP 请求方法
        /// </summary>
        /// <param name="method">请求方式</param>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP 请求方法</returns>
        public string DoHttpClient(string method, string url, IDictionary<string, string> parameters)
        {
            return method == HttpMethod.Post.Method ? this.DoPost(url, parameters) : this.DoGet(url, parameters);
        }

        /// <summary>
        /// 执行 HTTP POST 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP 响应</returns>
        public string DoPost(string url, IDictionary<string, string> parameters)
        {
            HttpWebRequest request = this.GetWebRequest(url, "POST");
            byte[] postData = Encoding.GetEncoding("UTF-8").GetBytes(BuildQuery(parameters));
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return this.GetResponseAsString(response);
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

            HttpWebRequest request = this.GetWebRequest(url, "GET");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return this.GetResponseAsString(response);
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
            // yunzhanghu-sdk-{开发语言}/{sdk版本}/{各语言运行时版本}
            req.UserAgent = string.Format("yunzhanghu-sdk-net/1.0.5/{0}", Environment.Version.ToString());
            req.Timeout = this.Timeout;
            req.ReadWriteTimeout = this.ReadWritTimeout;
            req.ContentType = "application/x-www-form-urlencoded";
            if (this.CustomHeaders != null && this.CustomHeaders.Count > 0)
            {
                foreach (var header in this.CustomHeaders)
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
        /// 响应流转换为文本
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
                if (reader != null)
                {
                    reader.Close();
                }

                if (stream != null)
                {
                    stream.Close();
                }

                if (response != null)
                {
                    response.Close();
                }
            }

            return UnicodeDecode(result.ToString());
        }

        /// <summary>
        /// Unicode 解码
        /// </summary>
        /// <param name="unicodeStr">Unicode 字符串</param>
        /// <returns>解码后的字符串</returns>
        public static string UnicodeDecode(string unicodeStr)
        {
            if (string.IsNullOrWhiteSpace(unicodeStr) || (!unicodeStr.Contains("\\u") && !unicodeStr.Contains("\\U")))
            {
                return unicodeStr;
            }

            string newStr = Regex.Replace(unicodeStr, @"\\[uU](.{4})", (m) =>
            {
                string unicode = m.Groups[1].Value;
                if (int.TryParse(unicode, System.Globalization.NumberStyles.HexNumber, null, out int temp))
                {
                    return ((char)temp).ToString();
                }
                else
                {
                    return m.Groups[0].Value;
                }
            }, RegexOptions.Singleline);

            return newStr;
        }
    }
}