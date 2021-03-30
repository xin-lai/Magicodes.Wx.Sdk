using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class GetBlackListInput
    {
        /// <summary>
        /// 当 begin_openid 为空时，默认从开头拉取
        /// </summary>
        [JsonProperty("begin_openid")]
        public string BeginOpenId { get; set; }
    }
}