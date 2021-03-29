using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class DeleteTagInput
    {
        [JsonProperty("tag")]
        public DeleteTagInfo Tag { get; set; }
    }

    public class DeleteTagInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}