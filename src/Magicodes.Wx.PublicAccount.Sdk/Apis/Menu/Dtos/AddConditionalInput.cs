using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    public class AddConditionalInput
    {
        /// <summary>
        ///一级菜单数组，个数应为1~3个
        /// </summary>
        [JsonProperty("button")]
        public List<MenuButtonBase> Button { get; set; }

        /// <summary>
        /// 菜单匹配规则
        /// </summary>
        [JsonProperty("matchrule")]
        public MatchRule MatchRule { get; set; }
    }
}