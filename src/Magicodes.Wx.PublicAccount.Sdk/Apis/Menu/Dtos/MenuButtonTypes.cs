namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     菜单类型
    /// </summary>
    public enum MenuButtonTypes
    {
        /// <summary>
        ///     点击推事件
        /// </summary>
        click = 1,

        /// <summary>
        ///     跳转URL
        /// </summary>
        view = 2,

        /// <summary>
        ///     扫码推事件
        /// </summary>
        scancode_push = 3,

        /// <summary>
        ///     扫码推事件且弹出“消息接收中”提示框
        /// </summary>
        scancode_waitmsg = 4,

        /// <summary>
        ///     弹出系统拍照发图
        /// </summary>
        pic_sysphoto = 5,

        /// <summary>
        ///     弹出拍照或者相册发图
        /// </summary>
        pic_photo_or_album = 6,

        /// <summary>
        ///     弹出微信相册发图器
        /// </summary>
        pic_weixin = 7,

        /// <summary>
        ///     弹出地理位置选择器
        /// </summary>
        location_select = 8,

        /// <summary>
        ///     下发消息（除文本消息）
        /// </summary>
        media_id = 9,

        /// <summary>
        ///     跳转图文消息URL
        /// </summary>
        view_limited = 10,

        /// <summary>
        ///     小程序
        /// </summary>
        miniprogram = 11
    }
}