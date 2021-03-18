using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendImageInput" />
    /// </summary>
    public class SendImageInput : SendInputBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendImageInput"/> class.
        /// </summary>
        public SendImageInput()
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
            [JsonProperty("media_ids")]
            public List<string> MediaIds { get; set; }

            /// <summary>
            /// 推荐语，不填则默认为“分享图片”
            /// </summary>
            public string recommend { get; set; }

            public int need_open_comment { get; set; }
            public int only_fans_can_comment { get; set; }
        }
    }
}