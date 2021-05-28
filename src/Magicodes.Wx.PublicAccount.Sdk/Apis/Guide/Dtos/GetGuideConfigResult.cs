using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideConfigResult : ApiResultBase
    {
        /// <summary>
        /// 快捷回复列表
        /// </summary>
        [JsonProperty("guide_fast_reply_list")]
        public List<GuideFastReplyInfo> GuideFastReplyList { get; set; }

        /// <summary>
        /// 第一条新客户关注自动回复
        /// </summary>
        [JsonProperty("guide_auto_reply")]
        public GuideAutoReplyInfo GuideAutoReply { get; set; }

        /// <summary>
        /// 第二条新客户关注自动回复
        /// </summary>
        [JsonProperty("guide_auto_reply_plus")]
        public GuideAutoReplyPlusInfo GuideAutoReplyPlus { get; set; }
    }
}