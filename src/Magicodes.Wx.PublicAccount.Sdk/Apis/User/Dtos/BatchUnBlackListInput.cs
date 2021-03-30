using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class BatchUnBlackListInput
    {
        /// <summary>
        /// 需要取消拉入黑名单的用户的openid，一次最多允许20个
        /// </summary>
        [JsonProperty("openid_list")]
        public string[] OpenIdList { get; set; }
    }
}