using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="PreviewNewsInput" />
    /// </summary>
    public class PreviewNewsInput : PreviewInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewNewsInput"/> class.
        /// </summary>
        public PreviewNewsInput()
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