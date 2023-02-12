using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aop.Api.Domain;


namespace Aop.Api.Response
{
   /// <summary>
   /// 获取协议预览 URL
   /// <summary>
   public class ApiUseSignContractResponse : AopResponse
   {
      /// <summary>
      /// 获取协议预览 URL
      /// <summary>
      [JsonProperty("data")]
      public ApiUseSignContractResponseModel Data { get; set; }

   }
}