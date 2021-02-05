using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Menu
{
    public class NewsInfo
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "digest")]
        public string Digest { get; set; }

        [JsonProperty(PropertyName = "show_cover")]
        public int ShowCover { get; set; }

        [JsonProperty(PropertyName = "cover_url")]
        public string CoverUrl { get; set; }

        [JsonProperty(PropertyName = "content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty(PropertyName = "source_url")]
        public string SourceUrl { get; set; }
    }
}