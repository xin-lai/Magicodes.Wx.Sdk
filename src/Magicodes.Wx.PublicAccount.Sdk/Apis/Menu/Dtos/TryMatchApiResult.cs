using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu.Dtos
{
    public class TryMatchApiResult : ApiResultBase
    {
        /// <summary>
        /// 一级菜单数组，个数应为1~3个
        /// </summary>
        [JsonProperty("button")]
        public ButtonInfo[] Button { get; set; }
    }

    public class ButtonInfo
    {
        /// <summary>
        /// 菜单的响应动作类型，view表示网页类型，click表示点击类型，miniprogram表示小程序类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 菜单标题，不超过16个字节，子菜单不超过40个字节
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 网页链接，用户点击菜单可打开链接，不超过1024字节。当type为miniprogram时，不支持小程序的老版本客户端将打开本url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 二级菜单数组，个数应为1~5个
        /// </summary>
        [JsonProperty("sub_button")]
        public ButtonInfo[] SubButton { get; set; }
    }
}