using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendVideoInput" />
    /// </summary>
    public class SendVideoInput : SendInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendVideoInput"/> class.
        /// </summary>
        public SendVideoInput()
        {
            MessageType = MessageTypes.video;
        }

        /// <summary>
        /// Gets or sets the Video
        /// </summary>
        [JsonProperty("video")]
        public VideoInfo Video { get; set; }

        /// <summary>
        /// Defines the <see cref="VideoInfo" />
        /// </summary>
        public class VideoInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            [JsonProperty("media_id")]
            public string MediaId { get; set; }
        }
    }
}