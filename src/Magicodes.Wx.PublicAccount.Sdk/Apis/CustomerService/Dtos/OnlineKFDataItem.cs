using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    /// <summary>
    /// 获取客服基本信息返回结果
    /// </summary>
    public class OnlineKFDataItem
    {
        
        /// <summary>
        /// 客服编号
        /// </summary>
        [JsonProperty("kf_id")]
        public string Id { get; set; }

        /// <summary>
        /// 完整客服帐号，格式为：帐号前缀@公众号微信号
        /// </summary>
        [JsonProperty("kf_account")]
        public string Account { get; set; }
        /// <summary>
        /// 客服当前正在接待的会话数
        /// </summary>
        [JsonProperty("accepted_case")]
        public int AcceptedCase { get; set; }
        /// <summary>
        /// 客服在线状态，目前为：1、web 在线
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

    }
}