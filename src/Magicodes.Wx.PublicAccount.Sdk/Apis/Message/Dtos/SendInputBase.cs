using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendInputBase" />
    /// </summary>
    public abstract class SendInputBase
    {
        /// <summary>
        /// Gets or sets the ToUsers
        /// 填写图文消息的接收者，一串OpenID列表，OpenID最少2个，最多10000个
        /// </summary>
        [JsonProperty("touser")]
        public ICollection<string> ToUsers { get; set; }

        /// <summary>
        /// Gets or sets the MessageType
        /// 群发的消息类型，图文消息为mpnews，文本消息为text，语音为voice，音乐为music，图片为image，视频为video，卡券为wxcard
        /// </summary>
        [JsonProperty("msgtype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageTypes MessageType { get; internal set; }

        /// <summary>
        /// 图文消息被判定为转载时，是否继续群发。 1为继续群发（转载），0为停止群发。 该参数默认为0。
        /// </summary>
        public int send_ignore_reprint { get; set; }
    }
}