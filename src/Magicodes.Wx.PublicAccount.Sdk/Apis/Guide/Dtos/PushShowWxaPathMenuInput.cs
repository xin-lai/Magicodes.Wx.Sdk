using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class PushShowWxaPathMenuInput
    {
        /// <summary>
        /// 小程序appid，暂时只支持小程序，不支持小游戏
        /// </summary>
        [JsonProperty("wxa_appid")]
        public string WxaAppid { get; set; }

        /// <summary>
        /// 关注该公众号的微信号
        /// </summary>
        [JsonProperty("wx_username")]
        public string WxUserName { get; set; }
    }
}