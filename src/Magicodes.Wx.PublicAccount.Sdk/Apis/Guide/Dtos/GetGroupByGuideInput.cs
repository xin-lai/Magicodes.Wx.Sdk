using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGroupByGuideInput
    {
        /// <summary>
        /// 顾问微信号
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }
    }
}