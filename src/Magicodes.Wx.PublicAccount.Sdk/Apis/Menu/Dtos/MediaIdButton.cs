namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     下发消息（除文本消息）
    ///     用户点击media_id类型按钮后，微信服务器会将开发者填写的永久素材id对应的素材下发给用户，永久素材类型可以是图片、音频、视频、图文消息。请注意：永久素材id必须是在“素材管理/新增永久素材”接口上传后获得的合法id。
    /// </summary>
    public class MediaIdButton : MenuButtonBase
    {
        public MediaIdButton()
        {
            Type = MenuButtonTypes.media_id;
        }
    }
}