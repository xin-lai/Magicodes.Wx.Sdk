using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideWordMaterialInput
    {
        /// <summary>
        /// 操作类型，填0，表示服务号素材
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 分页查询，起始位置
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; set; }

        /// <summary>
        /// 分页查询，查询个数
        /// </summary>
        [JsonProperty("num")]
        public int Num { get; set; }
    }
}