using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideWordMaterialResult : ApiResultBase
    {
        /// <summary>
        /// 文字素材列表
        /// </summary>
        [JsonProperty("word_list")]
        public List<GuideWordMaterialWordInfo> WordList { get; set; }

        /// <summary>
        /// 文字素材总数
        /// </summary>
        [JsonProperty("total_num")]
        public int TotalNum { get; set; }
    }

    public class GuideWordMaterialWordInfo
    {
        /// <summary>
        /// 文字素材内容
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }
    }
}