using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class QueryGuideBuyerByTagInput
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
        /// 本月还可主动发消息次数
        /// </summary>
        [JsonProperty("push_count")]
        public int PushCount { get; set; }

        /// <summary>
        /// 标签值，该值必须在标签可选值集合中
        /// </summary>
        [JsonProperty("tag_values")]
        public List<string> TagValues { get; set; }
    }
}