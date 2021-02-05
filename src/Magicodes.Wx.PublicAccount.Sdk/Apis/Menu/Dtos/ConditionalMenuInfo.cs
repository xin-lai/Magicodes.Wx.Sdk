using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     个性化菜单
    /// </summary>
    public class ConditionalMenuInfo
    {
        [JsonProperty("button")]
        public List<MenuButtonBase> Button { get; set; }

        [JsonProperty("matchrule")]
        public MatchRule MatchRule { get; set; }
    }
}