using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    public class AddConditionalApiResult
    {
        [JsonProperty("menuid")]
        public string MenuId { get; set; }
    }
}