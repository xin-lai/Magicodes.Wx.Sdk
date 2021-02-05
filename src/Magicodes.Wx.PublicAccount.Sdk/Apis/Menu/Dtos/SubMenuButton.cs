using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     子菜单按钮
    /// </summary>
    public class SubMenuButton : MenuButtonBase
    {
        /// <summary>
        ///     菜单标题，不超过16个字节，子菜单不超过40个字节
        /// </summary>
        [MaxLength(8)]
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public override string Name { get; set; }

        /// <summary>
        ///     子菜单（二级菜单数组，个数应为1~5个）
        /// </summary>
        [JsonProperty(PropertyName = "sub_button")]
        public List<MenuButtonBase> SubButtons { get; set; }
    }
}