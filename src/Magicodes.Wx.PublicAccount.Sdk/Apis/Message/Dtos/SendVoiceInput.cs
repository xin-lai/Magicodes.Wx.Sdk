using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendVoiceInput" />
    /// </summary>
    public class SendVoiceInput : SendInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendVoiceInput"/> class.
        /// </summary>
        public SendVoiceInput()
        {
            MessageType = MessageTypes.voice;
        }

        /// <summary>
        /// Gets or sets the Voice
        /// </summary>
        [JsonProperty("voice")]
        public VoiceInfo Voice { get; set; }

        /// <summary>
        /// Defines the <see cref="VoiceInfo" />
        /// </summary>
        public class VoiceInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            [JsonProperty("media_id")]
            public string MediaId { get; set; }
        }
    }
}