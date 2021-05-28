using Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Guide
{
    /// <summary>
    /// 顾问管理
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/guide/")]
    public interface IGuideApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 为服务号添加顾问
        /// </summary>
        /// <returns></returns>
        [HttpPost("addguideacct")]
        Task<ApiResultBase> AddGuideAcctAsync([JsonNetContent(CharSet = "utf-8")] AddGuideAcctInput input);

        /// <summary>
        /// 获取顾问信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguideacct")]
        Task<GetGuideAcctApiResult> GetGuideAcctAsync([JsonNetContent(CharSet = "utf-8")] GetGuideAcctInput input);

        /// <summary>
        /// 修改顾问的昵称或头像
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("updateguideacct")]
        Task<ApiResultBase> UpdateGuideAcctAsync([JsonNetContent(CharSet = "utf-8")] UpdateGuideAcctInput input);

        /// <summary>
        /// 删除顾问
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguideacct")]
        Task<ApiResultBase> DelGuideAcctAsync([JsonNetContent(CharSet = "utf-8")] DelGuideAcctApiInput input);

        /// <summary>
        /// 获取服务号顾问列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguideacctlist")]
        Task<GetGuideAcctListResult> GetGuideAcctListAsync([JsonNetContent(CharSet = "utf-8")] GetGuideAcctListInput input);

        /// <summary>
        /// 生成顾问二维码
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("guidecreateqrcode")]
        Task<GuideCreateQrCodeResult> GuideCreateQrCodeAsync([JsonNetContent(CharSet = "utf-8")] GuideCreateQrCodeInput input);

        /// <summary>
        /// 获取顾问聊天记录
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidebuyerchatrecord")]
        Task<GetGuideBuyerChatRecordResult> GetGuideBuyerChatRecordAsync([JsonNetContent(CharSet = "utf-8")] GetGuideBuyerChatRecordInput input);

        /// <summary>
        /// 设置快捷回复与关注自动回复
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("setguideconfig")]
        Task<ApiResultBase> SetGuideConfigAsync([JsonNetContent(CharSet = "utf-8")] SetGuideConfigInput input);

        /// <summary>
        /// 获取快捷回复与关注自动回复
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguideconfig")]
        Task<GetGuideConfigResult> GetGuideConfigAsync([JsonNetContent(CharSet = "utf-8")] GetGuideConfigInput input);

        /// <summary>
        /// 设置离线自动回复与敏感词
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("setguideacctconfig")]
        Task<GetGuideConfigResult> SetGuideAcctConfigAsync([JsonNetContent(CharSet = "utf-8")] SetGuideAcctConfigInput input);

        /// <summary>
        /// 获取离线自动回复与敏感词
        /// </summary>
        /// <returns></returns>
        [HttpPost("getguideacctconfig")]
        Task<GetGuideAcctConfigResult> GetGuideAcctConfigAsync();
    }
}