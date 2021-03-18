using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendAllNewsInput" />
    /// </summary>
    public class SendAllNewsInput : SendAllInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendAllNewsInput"/> class.
        /// </summary>
        public SendAllNewsInput()
        {
            MessageType = MessageTypes.mpnews;
        }

        /// <summary>
        /// Gets or sets the News
        /// </summary>
        [JsonProperty("mpnews")]
        public NewsInfo News { get; set; }

        /// <summary>
        /// 开发者侧群发msgid，长度限制64字节，如不填，则后台默认以群发范围和群发内容的摘要值做为clientmsgid
        /// </summary>
        public string clientmsgid { get; set; }

        /// <summary>
        /// Defines the <see cref="NewsInfo" />
        /// </summary>
        public class NewsInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            [JsonProperty("media_id")]
            public string MediaId { get; set; }
        }
    }
}