using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     弹出拍照或者相册发图
    ///     用户点击按钮后，微信客户端将弹出选择器供用户选择“拍照”或者“从手机相册选择”。用户选择后即走其他两种流程。
    /// </summary>
    public class PicPhotoOrAlbumButton : MenuButtonBase
    {
        public PicPhotoOrAlbumButton()
        {
            Type = MenuButtonTypes.pic_photo_or_album;
        }

        /// <summary>
        ///     菜单KEY值，用于消息接口推送，不超过128字节
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.Always)]
        public new string Key { get; set; }
    }
}