using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GuideCreateQrCodeResult : ApiResultBase
    {
        /// <summary>
        /// 点击链接即可下载生成的二维码
        /// </summary>
        [JsonProperty("qrcode_url")]
        public string QrCodeUrl { get; set; }
    }
}