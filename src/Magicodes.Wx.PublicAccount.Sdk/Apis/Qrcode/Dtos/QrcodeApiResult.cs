using Newtonsoft.Json;
using System;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Qrcode
{
    /// <summary>
    /// 
    /// </summary>
    public class QrcodeApiResult : ApiResultBase
    {
        /// <summary>
        /// 获取的二维码ticket，凭借此 ticket 可以在有效时间内换取二维码。
        /// </summary>
        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        /// <summary>
        /// 该二维码有效时间，以秒为单位。 最大不超过2592000（即30天）。
        /// </summary>
        [JsonProperty("expire_seconds")]
        public int ExpireSeconds { get; set; }

        /// <summary>
        /// 二维码图片解析后的地址，开发者可根据该地址自行生成需要的二维码图片
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}