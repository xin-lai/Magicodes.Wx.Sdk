using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    /// <summary>
    /// Defines the <see cref="SendAllInputBase" />
    /// </summary>
    public abstract class SendAllInputBase
    {
        /// <summary>
        /// Gets or sets the Filter
        /// 用于设定图文消息的接收者
        /// </summary>
        [JsonProperty("filter")]
        public FilterInfo Filter { get; set; }

        /// <summary>
        /// Gets or sets the MessageType
        /// 群发的消息类型，图文消息为mpnews，文本消息为text，语音为voice，音乐为music，图片为image，视频为video，卡券为wxcard
        /// </summary>
        [JsonProperty("msgtype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageTypes MessageType { get; internal set; }

        /// <summary>
        ///图文消息被判定为转载时，是否继续群发。 1为继续群发（转载），0为停止群发。 该参数默认为0。
        /// </summary>
        public int send_ignore_reprint { get; set; }

        /// <summary>
        /// 用于设定消息的接收者
        /// </summary>
        public class FilterInfo
        {
            /// <summary>
            /// Gets or sets a value indicating whether IsToAll
            /// 用于设定是否向全部用户发送，值为true或false，选择true该消息群发给所有用户，选择false可根据group_id发送给指定群组的用户
            /// </summary>
            [JsonProperty("is_to_all")]
            public bool IsToAll { get; set; }

            /// <summary>
            ///群发到的标签的tag_id，参见用户管理中用户分组接口，若is_to_all值为true，可不填写tag_id
            /// </summary>
            [JsonProperty("tag_id")]
            public int TagId { get; set; }
        }
    }
}