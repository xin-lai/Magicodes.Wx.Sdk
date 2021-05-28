using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos
{
    public class SetGuideAcctConfigInput
    {
        /// <summary>
        /// 操作类型，false表示添加 true表示删除
        /// </summary>
        [JsonProperty("is_delete")]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 敏感词，每次全量更新覆盖原来数据（如果不设置就不传black_keyword字段）
        /// </summary>
        [JsonProperty("black_keyword")]
        public BlackKeywordInfo BlackKeyword { get; set; }

        /// <summary>
        /// 离线自动回复（如果不设置就不传guide_auto_reply字段）
        /// </summary>
        [JsonProperty("guide_auto_reply")]
        public GuideFastReplyInfo GuideAutoReply { get; set; }
    }

    public class BlackKeywordInfo
    {
        /// <summary>
        /// 敏感词列表
        /// </summary>
        [JsonProperty("values")]
        public string[] Values { get; set; }
    }
}