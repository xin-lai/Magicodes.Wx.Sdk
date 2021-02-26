namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class GetIndustryResult:ApiResultBase
    {
        /// <summary>
        /// 帐号设置的主营行业
        /// </summary>
        public IndustryInfo PrimaryIndustry { get; set; }
        /// <summary>
        /// 帐号设置的副营行业
        /// </summary>
        public IndustryInfo SecondaryIndustry { get; set; }


    }
}