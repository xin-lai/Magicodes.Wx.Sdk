using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    /// <summary>
    /// 获取客服基本信息返回结果
    /// </summary>
    public class KFDataItem
    {
        /// <summary>
        /// 完整客服帐号，格式为：帐号前缀@公众号微信号
        /// </summary>
        [JsonProperty("kf_account")]
        public string Account { get; set; }
        /// <summary>
        /// 客服头像
        /// </summary>
        [JsonProperty("kf_headimgurl")]
        public string Headimgurl { get; set; }
        /// <summary>
        /// 客服编号
        /// </summary>
        [JsonProperty("kf_id")]
        public string Id { get; set; }
        /// <summary>
        /// 客服昵称
        /// </summary>
        [JsonProperty("kf_nick")]
        public string Nick { get; set; }
        /// <summary>
        /// 如果客服帐号尚未绑定微信号，但是已经发起了一个绑定邀请， 则此处显示绑定邀请的微信号
        /// </summary>
        [JsonProperty("invite_wx")]
        public string InviteWX { get; set; }
        /// <summary>
        /// 如果客服帐号已绑定了客服人员微信号， 则此处显示微信号
        /// </summary>
        [JsonProperty("kf_wx")]
        public string KFWX { get; set; }
        /// <summary>
        /// 如果客服帐号尚未绑定微信号，但是已经发起过一个绑定邀请， 邀请的过期时间，为unix 时间戳
        /// </summary>
        [JsonProperty("invite_expire_time")]
        public int InviteExpireTime { get; set; }
        /// <summary>
        /// 邀请的状态，有等待确认“waiting”，被拒绝“rejected”， 过期“expired”
        /// </summary>
        [JsonProperty("invite_status")]
        public EInviteStatus InviteStatus { get; set; }

    }
}