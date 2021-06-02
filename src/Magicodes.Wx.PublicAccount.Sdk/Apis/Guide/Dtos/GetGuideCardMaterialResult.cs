using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideCardMaterialResult : ApiResultBase
    {
        /// <summary>
        /// 小程序卡片素材列表
        /// </summary>
        [JsonProperty("card_list")]
        public List<GuideCardMaterialInfo> CardList { get; set; }
    }

    public class GuideCardMaterialInfo
    {
        /// <summary>
        /// 卡片名字
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonProperty("picurl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [JsonProperty("master_id")]
        public int MasterId { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [JsonProperty("slave_id")]
        public int SlaveId { get; set; }
    }
}