using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     跳转图文消息URL
    ///     用户点击view_limited类型按钮后，微信客户端将打开开发者在按钮中填写的永久素材id对应的图文消息URL，永久素材类型只支持图文消息。请注意：永久素材id必须是在“素材管理/新增永久素材”接口上传后获得的合法id。
    /// </summary>
    public class ViewLimitedButton : MenuButtonBase
    {
        public ViewLimitedButton()
        {
            Type = MenuButtonTypes.view_limited;
        }

        /// <summary>
        ///     调用新增永久素材接口返回的合法media_id
        /// </summary>
        [JsonProperty(PropertyName = "media_id", Required = Required.Always)]
        public new string MediaId { get; set; }
    }
}