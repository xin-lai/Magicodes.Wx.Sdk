using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    public class AddOrUpdateKfAccountInput
    {
        /// <summary>
        /// 完整客服帐号，格式为：帐号前缀@公众号微信号，帐号前缀最多10个字符，必须是英文、数字字符或者下划线，后缀为公众号微信号，长度不超过30个字符
        /// </summary>
        [JsonProperty("kf_account")]
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Account { get; set; }

        /// <summary>
        /// 客服昵称，最长16个字
        /// </summary>
        [JsonProperty("nickname")]
        [StringLength(16, MinimumLength = 1)]
        public string Nickname { get; set; }
    }
}