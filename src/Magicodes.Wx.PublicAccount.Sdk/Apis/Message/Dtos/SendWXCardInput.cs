using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendWXCardInput" />
    /// </summary>
    public class SendWXCardInput : SendInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendWXCardInput"/> class.
        /// </summary>
        public SendWXCardInput()
        {
            MessageType = MessageTypes.wxcard;
        }

        /// <summary>
        /// Gets or sets the WXCard
        /// </summary>
        [JsonProperty("wxcard")]
        public WXCardInfo WXCard { get; set; }

        /// <summary>
        /// Defines the <see cref="WXCardInfo" />
        /// </summary>
        public class WXCardInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            [JsonProperty("media_id")]
            public string MediaId { get; set; }
        }
    }
}