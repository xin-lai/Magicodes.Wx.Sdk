using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class SetIndustryInput
    {
        /// <summary>
        /// 公众号模板消息所属行业编号
        /// </summary>
        [JsonProperty("industry_id1")]
        public string IndustryId1 { get; set; }

        /// <summary>
        /// 公众号模板消息所属行业编号
        /// </summary>
        [JsonProperty("industry_id2")]
        public string IndustryId2 { get; set; }
    }
}