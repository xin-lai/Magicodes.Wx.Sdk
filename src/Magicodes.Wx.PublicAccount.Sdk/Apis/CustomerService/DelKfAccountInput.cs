using Newtonsoft.Json;

namespace Magicodes.WeChat.Sdk.Apis.CustomerService
{
    public class DelKfAccountInput
    {
        [JsonProperty("kf_account")]
        public string Account { get; set; }
    }
}