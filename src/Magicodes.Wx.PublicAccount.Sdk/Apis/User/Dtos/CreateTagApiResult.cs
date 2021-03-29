using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class CreateTagApiResult : ApiResultBase
    {
        [JsonProperty("tag")]
        public CreateTagResultInfo Tag { get; set; }
    }

    public class CreateTagResultInfo
    {
        /// <summary>
        /// 标签id，由微信分配
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 标签名，UTF8编码
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}