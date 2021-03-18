using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendAllVoiceInput" />
    /// </summary>
    public class SendAllVoiceInput : SendAllInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendAllVoiceInput"/> class.
        /// </summary>
        public SendAllVoiceInput()
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