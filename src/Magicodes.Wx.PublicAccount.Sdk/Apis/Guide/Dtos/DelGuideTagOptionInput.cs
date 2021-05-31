using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class DelGuideTagOptionInput
    {
        /// <summary>
        /// 标签类型的名字
        /// </summary>
        [JsonProperty("tag_name")]
        public string TagName { get; set; }
    }
}