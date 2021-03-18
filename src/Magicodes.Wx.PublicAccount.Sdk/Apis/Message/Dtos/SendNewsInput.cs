using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendNewsInput" />
    /// </summary>
    public class SendNewsInput : SendInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendNewsInput"/> class.
        /// </summary>
        public SendNewsInput()
        {
            MessageType = MessageTypes.mpnews;
        }

        /// <summary>
        /// Gets or sets the News
        /// </summary>
        [JsonProperty("mpnews")]
        public NewsInfo News { get; set; }

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