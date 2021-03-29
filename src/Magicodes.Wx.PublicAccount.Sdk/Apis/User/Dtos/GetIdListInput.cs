using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class GetIdListInput
    {
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}