using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    public class InviteWorkerInput
    {

        /// <summary>
        /// 完整客服帐号，格式为：帐号前缀@公众号微信号
        /// </summary>
        [JsonProperty("kf_account")]
        public string Account { get; set; }
        /// <summary>
        /// 接收绑定邀请的客服微信号
        /// </summary>
        [JsonProperty("invite_wx")]
        public string InviteWX { get; set; }


    }
}