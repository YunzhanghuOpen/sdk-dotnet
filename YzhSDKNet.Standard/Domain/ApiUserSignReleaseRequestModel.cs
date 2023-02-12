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
   public class ApiUserSignReleaseRequestModel : AopObject
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
      /// 证件类型 idcard：身份证 mtphkm：港澳居民来往内地通行证 passport：护照 mtpt：台湾居民往来大陆通行证
      /// <summary>
      [JsonProperty("card_type")]
      public string CardType { get; set; }
      
   }
}