using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// H5 签约接口请求
   /// <summary>
   public class H5UserSignRequestModel : AopObject
   {
      /// <summary>
      /// H5 签约 token
      /// <summary>
      [JsonProperty("token")]
      public string Token { get; set; }
      
      /// <summary>
      /// H5 页面主题颜色
      /// <summary>
      [JsonProperty("color")]
      public string Color { get; set; }
      
      /// <summary>
      /// 回调 URL 地址
      /// <summary>
      [JsonProperty("url")]
      public string URL { get; set; }
      
      /// <summary>
      /// 跳转 URL
      /// <summary>
      [JsonProperty("redirect_url")]
      public string RedirectURL { get; set; }
      
   }
}