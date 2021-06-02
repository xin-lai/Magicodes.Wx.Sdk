using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideImageMaterialResult : ApiResultBase
    {
        /// <summary>
        /// 图片素材列表
        /// </summary>
        [JsonProperty("model_list")]
        public List<GuideImageMaterialModelInfo> ModelList { get; set; }

        /// <summary>
        /// 图片素材总数
        /// </summary>
        [JsonProperty("total_num")]
        public int TotalNum { get; set; }
    }

    public class GuideImageMaterialModelInfo
    {
        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonProperty("picurl")]
        public string PicUrl { get; set; }
    }
}