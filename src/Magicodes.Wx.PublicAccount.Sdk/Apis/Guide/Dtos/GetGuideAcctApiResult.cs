using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class GetGuideAcctApiResult : ApiResultBase
    {
        /// <summary>
        /// 顾问微信号（guide_account和guide_openid二选一，若同时请求，默认为guide_account）
        /// </summary>
        [JsonProperty("guide_account")]
        public string GuideAccount { get; set; }

        /// <summary>
        /// 顾问openid或者unionid（guide_account和guide_openid二选一）
        /// </summary>
        [JsonProperty("guide_openid")]
        public string GuideOpenId { get; set; }

        /// <summary>
        /// 顾问头像，头像url只能用《上传图文消息内的图片获取URL》
        /// </summary>
        [JsonProperty("guide_headimgurl")]
        public string GuideHeadImgUrl { get; set; }

        /// <summary>
        /// 顾问昵称
        /// </summary>
        [JsonProperty("guide_nickname")]
        public string GuideNickName { get; set; }

        /// <summary>
        /// 顾问状态（1:确认中；2已确认；3已拒绝；4已过期）
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}