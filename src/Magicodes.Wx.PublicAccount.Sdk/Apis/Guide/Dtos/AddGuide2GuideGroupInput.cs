using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class AddGuide2GuideGroupInput
    {
        /// <summary>
        /// 顾问分组id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 顾问微信号
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }
    }
}