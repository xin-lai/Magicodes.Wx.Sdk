using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class DelGuideImageMaterialInput
    {
        /// <summary>
        /// 操作类型，填0，表示服务号素材
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 图片素材内容
        /// </summary>
        [JsonProperty("picurl")]
        public string PicUrl { get; set; }
    }
}