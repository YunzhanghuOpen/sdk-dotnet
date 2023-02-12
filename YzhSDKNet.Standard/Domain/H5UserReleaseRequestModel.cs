using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aop.Api.Domain
{
   /// <summary>
   /// 用户解约请求
   /// <summary>
   public class H5UserReleaseRequestModel : AopObject
   {
      /// <summary>
      /// 综合服务主体 ID
      /// <summary>
      [JsonProperty("broker_id")]
      public string BrokerID { get; set; }
      
      /// <summary>
      /// 平台企业 ID
      /// <summary>
      [JsonProperty("dealer_id")]
      public string DealerID { get; set; }
      
      /// <summary>
      /// 姓名
      /// <summary>
      [JsonProperty("real_name")]
      public string RealName { get; set; }
      
      /// <summary>
      /// 证件号码
      /// <summary>
      [JsonProperty("id_card")]
      public string IDCard { get; set; }
      
      /// <summary>
      /// 证件类型   0：身份证 2：港澳居民来往内地通行证 3：护照 5：台湾居民来往大陆通行证
      /// <summary>
      [JsonProperty("certificate_type")]
      public int CertificateType { get; set; }
      
   }
}