using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    public class AddOrUpdateKfAccountInput
    {
        private string password;

        [JsonProperty("kf_account")]
        public string Account { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("password")]
        public string Password
        {
            get => password;
            set =>
                //MD5加密
                password = WxHelper.GetWeChatMd5(value);
        }
    }
}