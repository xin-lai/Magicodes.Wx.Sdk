using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendAllTextInput" />
    /// </summary>
    public class SendAllTextInput : SendAllInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendAllTextInput"/> class.
        /// </summary>
        public SendAllTextInput()
        {
            MessageType = MessageTypes.text;
        }

        /// <summary>
        /// Gets or sets the Text
        /// </summary>
        [JsonProperty("text")]
        public TextInfo Text { get; set; }

        /// <summary>
        /// Defines the <see cref="TextInfo" />
        /// </summary>
        public class TextInfo
        {
            /// <summary>
            /// Gets or sets the Content
            /// </summary>
            [JsonProperty("content")]
            public string Content { get; set; }
        }
    }
}