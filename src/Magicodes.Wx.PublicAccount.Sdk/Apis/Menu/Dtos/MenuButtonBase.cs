using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    /// <summary>
    ///     菜单按钮基类
    /// </summary>
    [JsonConverter(typeof(MenuButtonsCustomConverter))]
    public class MenuButtonBase
    {
        /// <summary>
        ///     菜单标题，不超过16个字节，子菜单不超过40个字节
        /// </summary>
        [MaxLength(20)]
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public virtual string Name { get; set; }

        [JsonProperty(PropertyName = "media_id")]
        public string MediaId { get; set; }

        [JsonProperty(PropertyName = "sub_button")]
        public List<MenuButtonBase> SubButton { get; set; }

        [JsonProperty(PropertyName = "news_info")]
        public List<NewsInfo> NewsInfo { get; set; }

        /// <summary>
        ///     菜单类型（菜单的响应动作类型）
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = "type")]
        public MenuButtonTypes Type { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        ///     小程序的appid（仅认证公众号可配置）（miniprogram类型必须）
        /// </summary>
        [JsonProperty(PropertyName = "appid")]
        public string AppId { get; set; }


        /// <summary>
        ///     小程序的页面路径
        /// </summary>
        [JsonProperty(PropertyName = "pagepath")]
        public string Pagepath { get; set; }
    }
}