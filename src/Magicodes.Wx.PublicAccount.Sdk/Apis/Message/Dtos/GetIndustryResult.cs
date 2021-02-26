using Newtonsoft.Json;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class GetIndustryResult:ApiResultBase
    {
        /// <summary>
        /// 帐号设置的主营行业
        /// </summary>
        [JsonProperty("primary_industry")]
        public IndustryInfo PrimaryIndustry { get; set; }
        /// <summary>
        /// 帐号设置的副营行业
        /// </summary>
        [JsonProperty("secondary_industry")]
        public IndustryInfo SecondaryIndustry { get; set; }


    }
}