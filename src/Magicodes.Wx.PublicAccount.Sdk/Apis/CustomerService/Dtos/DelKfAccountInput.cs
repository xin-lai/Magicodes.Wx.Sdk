using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    public class DelKfAccountInput
    {
        [JsonProperty("kf_account")]
        public string Account { get; set; }
    }
}