using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class SendTemplateMessageApiResult : ApiResultBase
    {
        [JsonProperty("msgid")]
        public string MessageId { get; set; }
    }
}