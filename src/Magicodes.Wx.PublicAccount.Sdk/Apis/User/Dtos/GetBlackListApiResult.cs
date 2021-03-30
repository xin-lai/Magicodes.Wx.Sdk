using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class GetBlackListApiResult : ApiResultBase
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("data")]
        public BlackDataInfo Data { get; set; }

        [JsonProperty("next_openid")]
        public string NextOpenId { get; set; }
    }

    public class BlackDataInfo
    {
        [JsonProperty("openid")]
        public string[] OpenId { get; set; }
    }
}