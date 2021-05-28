using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class NewGuideGroupResult : ApiResultBase
    {
        /// <summary>
        /// 顾问分组唯一id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }
    }
}