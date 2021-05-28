using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class SetGuideConfigInput
    {
        /// <summary>
        /// 顾问微信号（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 顾问openid或者unionid（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }

        /// <summary>
        /// 操作类型，false表示添加 true表示删除
        /// </summary>
        [JsonProperty("is_delete")]
        public bool IsDelete { get; set; }

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

    public class GuideFastReplyInfo
    {
        /// <summary>
        /// 快捷回复
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GuideAutoReplyInfo
    {
        /// <summary>
        /// 新客户关注自动回复内容,图片填mediaid,获取方式同图片素材,小程序卡片填下面请求demo中字段的json格式
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 1表示文字，2表示图片，3表示小程序卡片
        /// </summary>
        [JsonProperty("msgtype")]
        public int MsgType { get; set; }
    }

    public class GuideAutoReplyPlusInfo : GuideAutoReplyInfo
    {
    }
}