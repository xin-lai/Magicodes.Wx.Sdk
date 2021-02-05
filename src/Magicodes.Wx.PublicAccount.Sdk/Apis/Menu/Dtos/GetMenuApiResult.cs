using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    public class GetMenuApiResult : ApiResultBase
    {
        [JsonProperty("menu")]
        public MenuInfo Menu { get; set; }
    }
}