using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideBuyerDisplayTagResult : ApiResultBase
    {
        /// <summary>
        /// 展示标签值
        /// </summary>
        [JsonProperty("display_tag_list")]
        public string DisplayTagList { get; set; }
    }
}