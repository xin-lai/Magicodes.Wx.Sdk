using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGroupInfoResult : ApiResultBase
    {
        /// <summary>
        /// 顾问分组列表
        /// </summary>
        [JsonProperty("guide_list")]
        public List<GetGroupInfo> GuideList { get; set; }

        /// <summary>
        /// 组内顾问人员总数
        /// </summary>
        [JsonProperty("total_num")]
        public int TotalNum { get; set; }
    }

    public class GetGroupInfo
    {
        /// <summary>
        /// 如果绑定顾问的时候，是用guide_accout参数绑定，拉取时才有这个数据
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 如果绑定顾问的时候，是用guide_openid参数绑定，拉取时才有这个数据
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }

        /// <summary>
        /// 顾问头像
        /// </summary>
        [JsonProperty("guide_headimgurl")]
        public string GuideHeadImgUrl { get; set; }

        /// <summary>
        /// 顾问昵称
        /// </summary>
        [JsonProperty("guide_nickname")]
        public string GuideNickName { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }
    }
}