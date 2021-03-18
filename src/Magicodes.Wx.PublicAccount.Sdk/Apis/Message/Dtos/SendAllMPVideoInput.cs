using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendAllMPVideoInput" />
    /// </summary>
    public class SendAllMPVideoInput : SendAllInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendAllMPVideoInput"/> class.
        /// </summary>
        public SendAllMPVideoInput()
        {
            MessageType = MessageTypes.mpvideo;
        }

        /// <summary>
        /// Gets or sets the MPVideo
        /// </summary>
        [JsonProperty("mpvideo")]
        public MPVideoInfo MPVideo { get; set; }

        /// <summary>
        /// Defines the <see cref="MPVideoInfo" />
        /// </summary>
        public class MPVideoInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            [JsonProperty("media_id")]
            public string MediaId { get; set; }
        }
    }
}