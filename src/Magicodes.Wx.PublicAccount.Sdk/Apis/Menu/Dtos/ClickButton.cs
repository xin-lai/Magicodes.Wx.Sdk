using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     Click按钮（点击推事件）
    ///     用户点击click类型按钮后，微信服务器会通过消息接口推送消息类型为event的结构给开发者（参考消息接口指南），并且带上按钮中开发者填写的key值，开发者可以通过自定义的key值与用户进行交互；
    /// </summary>
    public class ClickButton : MenuButtonBase
    {
        public ClickButton()
        {
            Type = MenuButtonTypes.click;
        }

        /// <summary>
        ///     菜单KEY值，用于消息接口推送，不超过128字节
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.Always)]
        public new string Key { get; set; }
    }
}