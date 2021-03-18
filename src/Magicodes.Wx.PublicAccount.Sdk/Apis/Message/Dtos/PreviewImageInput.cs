using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="PreviewImageInput" />
    /// </summary>
    public class PreviewImageInput : PreviewInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewImageInput"/> class.
        /// </summary>
        public PreviewImageInput()
        {
            MessageType = MessageTypes.image;
        }

        /// <summary>
        /// Gets or sets the Image
        /// </summary>
        [JsonProperty("image")]
        public ImageInfo Image { get; set; }

        /// <summary>
        /// Defines the <see cref="ImageInfo" />
        /// </summary>
        public class ImageInfo
        {
            /// <summary>
            /// Gets or sets the MediaId
            /// </summary>
            [JsonProperty("media_id")]
            public string MediaId { get; set; }
        }
    }
}