using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class SendTemplateMessageApiResult
    {
        [JsonProperty("msgid")]
        public string MessageId { get; set; }
    }
}