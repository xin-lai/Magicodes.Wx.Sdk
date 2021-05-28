using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideBuyerChatRecordInput
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
        /// 若不填，则拉取该顾问所有客户的聊天记录。若填写，则拉取顾问与某一个客户的聊天记录。
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 消息的起始UNIX时间戳，如果不填，默认当前时间的前30天(仅支持30天范围内的查询)
        /// </summary>
        [JsonProperty("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 消息的截止UNIX时间戳，如果不填，默认当前时间。
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页页数，从0开始
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("num")]
        public string Num { get; set; }
    }
}