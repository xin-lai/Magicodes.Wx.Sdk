using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideAcctListResult : ApiResultBase
    {
        /// <summary>
        /// 顾问总数量
        /// </summary>
        [JsonProperty("total_num")]
        public int TotalNum { get; set; }

        /// <summary>
        /// 账号列表
        /// </summary>
        [JsonProperty("list")]
        public List<GuideAcctInfo> List { get; set; }
    }

    public class GuideAcctInfo
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
    }
}