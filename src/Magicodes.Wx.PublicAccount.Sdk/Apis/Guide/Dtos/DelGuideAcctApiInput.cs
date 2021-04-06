using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class DelGuideAcctApiInput
    {
        /// <summary>
        /// 顾问微信号（guide_account和guide_openid二选一，若同时请求，默认为guide_account）
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 顾问openid或者unionid（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }
    }
}