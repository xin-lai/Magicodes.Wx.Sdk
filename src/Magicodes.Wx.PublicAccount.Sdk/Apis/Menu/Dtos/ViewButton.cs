using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     View按钮（跳转URL）
    ///     用户点击view类型按钮后，微信客户端将会打开开发者在按钮中填写的网页URL，可与网页授权获取用户基本信息接口结合，获得用户基本信息。
    /// </summary>
    public class ViewButton : MenuButtonBase
    {
        public ViewButton()
        {
            Type = MenuButtonTypes.view;
        }

        /// <summary>
        ///     网页链接，用户点击菜单可打开链接，不超过1024字节
        /// </summary>
        [MaxLength(500)]
        [JsonProperty(PropertyName = "url", Required = Required.Always)]
        public new string Url { get; set; }
    }
}