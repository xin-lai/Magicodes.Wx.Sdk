using Newtonsoft.Json;

namespace Magicodes.WeChat.Sdk.Apis.Message
{
    public class SendTemplateMessageApiResult
    {
        [JsonProperty("msgid")]
        public string MessageId { get; set; }
    }
}