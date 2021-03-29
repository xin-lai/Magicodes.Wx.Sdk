using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class CreateTagInput
    {
        [JsonProperty("tag")]
        public CreateTagModel Tag { get; set; }
    }

    public class CreateTagModel
    {
        /// <summary>
        /// 标签名（30个字符以内）
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}