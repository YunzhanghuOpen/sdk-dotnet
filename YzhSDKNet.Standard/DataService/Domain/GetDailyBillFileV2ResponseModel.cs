using Newtonsoft.Json;

namespace Aop.Api.Domain
{
   /// <summary>
   /// 查询日流水文件返回
   /// </summary>
   public class GetDailyBillFileV2ResponseModel : AopObject
   {
      /// <summary>
      /// 下载地址
      /// </summary>
      [JsonProperty("bill_download_url")]
      public string BillDownloadURL { get; set; }
   }
}