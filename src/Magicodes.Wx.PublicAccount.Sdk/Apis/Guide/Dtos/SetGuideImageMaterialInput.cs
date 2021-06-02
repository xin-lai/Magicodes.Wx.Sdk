using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class SetGuideImageMaterialInput
    {
        /// <summary>
        /// 图片素材，只能用《素材管理获取media_id》
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 操作类型，填0，表示服务号素材
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
    }
}