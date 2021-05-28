using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideBuyerChatRecordResult : ApiResultBase
    {
        /// <summary>
        /// 聊天记录总数
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// 聊天记录列表
        /// </summary>
        [JsonProperty("list")]
        public List<MsgInfo> List { get; set; }
    }

    public class MsgInfo
    {
        /// <summary>
        /// 顾问微信号
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 客户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 聊天记录生成时间
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// 聊天内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 聊天记录类型
        /// 1	文字类型
        /// 3	图片类型
        /// 49	小程序卡片类型
        /// </summary>
        [JsonProperty("content_type")]
        public int ContentType { get; set; }

        /// <summary>
        /// 消息指向
        /// 1	顾问发送消息给客户
        /// 2	客户发送消息给顾问
        /// </summary>
        [JsonProperty("direction")]
        public int Direction { get; set; }
    }
}