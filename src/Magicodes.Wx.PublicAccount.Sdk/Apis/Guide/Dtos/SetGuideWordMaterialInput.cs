using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class SetGuideWordMaterialInput
    {
        /// <summary>
        /// 操作类型，填0，表示服务号素材
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 文字素材内容 文字素材最多支持 300 字。
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }
    }
}