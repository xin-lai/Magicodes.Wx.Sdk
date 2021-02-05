using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    public class SelfMenuButtonBase
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
        public SubButton SubButton { get; set; }

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
    }
}