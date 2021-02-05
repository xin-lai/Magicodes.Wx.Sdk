using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    /// 小程序菜单
    /// </summary>
    public class MiniprogramButton : MenuButtonBase
    {
        public MiniprogramButton()
        {
            Type = MenuButtonTypes.miniprogram;
        }

        /// <summary>
        ///     小程序的appid（仅认证公众号可配置）（miniprogram类型必须）
        /// </summary>
        [JsonProperty(PropertyName = "appid")]
        public new string AppId { get; set; }

        /// <summary>
        ///     小程序的页面路径
        /// </summary>
        [JsonProperty(PropertyName = "pagepath")]
        public new string Pagepath { get; set; }
    }
}