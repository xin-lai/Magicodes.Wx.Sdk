using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos
{
    public class BatchBlackListInput
    {
        /// <summary>
        /// 需要拉入黑名单的用户的openid，一次拉黑最多允许20个
        /// </summary>
        [JsonProperty("openid_list")]
        public string[] OpenIdList { get; set; }
    }
}