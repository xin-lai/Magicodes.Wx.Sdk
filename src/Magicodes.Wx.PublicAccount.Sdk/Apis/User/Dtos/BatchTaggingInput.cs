using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class BatchTaggingInput
    {
        /// <summary>
        /// 粉丝列表
        /// </summary>
        [JsonProperty("openid_list")]
        public string[] OpenIdList { get; set; }

        [JsonProperty("tagid")]
        public int TagId { get; set; }
    }
}