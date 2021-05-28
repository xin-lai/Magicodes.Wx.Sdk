using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class DelGuideGroupInput
    {
        /// <summary>
        /// 顾问分组id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }
    }
}