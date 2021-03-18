using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="PreviewInputBase" />
    /// </summary>
    public abstract class PreviewInputBase
    {
        /// <summary>
        /// Gets or sets the ToUser
        /// 填写图文消息的接收者，一串OpenID列表，OpenID最少2个，最多10000个
        /// </summary>
        [JsonProperty("touser", NullValueHandling = NullValueHandling.Ignore)]
        public string ToUser { get; set; }

        /// <summary>
        /// Gets or sets the ToWXName
        /// 微信号（如果设置了此值，则ToUser设置无效）
        /// </summary>
        [JsonProperty("towxname", NullValueHandling = NullValueHandling.Ignore)]
        public string ToWXName { get; set; }

        /// <summary>
        /// Gets or sets the MessageType
        /// 群发的消息类型，图文消息为mpnews，文本消息为text，语音为voice，音乐为music，图片为image，视频为video，卡券为wxcard
        /// </summary>
        [JsonProperty("msgtype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageTypes MessageType { get; internal set; }
    }
}