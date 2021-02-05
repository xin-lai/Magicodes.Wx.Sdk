using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     弹出地理位置选择器
    ///     用户点击按钮后，微信客户端将调起地理位置选择工具，完成选择操作后，将选择的地理位置发送给开发者的服务器，同时收起位置选择工具，随后可能会收到开发者下发的消息。
    /// </summary>
    public class LocationSelectButton : MenuButtonBase
    {
        public LocationSelectButton()
        {
            Type = MenuButtonTypes.location_select;
        }

        /// <summary>
        ///     菜单KEY值，用于消息接口推送，不超过128字节
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.Always)]
        public new string Key { get; set; }
    }
}