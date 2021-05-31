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

        /// <summary>
        /// 允许微信用户复制小程序页面路径
        /// </summary>
        /// <returns></returns>
        [HttpPost("pushshowwxapathmenu")]
        Task<ApiResultBase> PushShowWxaPathMenuAsync([JsonNetContent(CharSet = "utf-8")] PushShowWxaPathMenuInput input);

        /// <summary>
        /// 新建顾问分组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("newguidegroup")]
        Task<NewGuideGroupResult> NewGuideGroupAsync([JsonNetContent(CharSet = "utf-8")] NewGuideGroupInput input);

        /// <summary>
        /// 获取顾问分组列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("getguidegrouplist")]
        Task<GetGuideGroupListResult> GetGuideGroupListAsync();

        /// <summary>
        /// 获取顾问分组信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getgroupinfo")]
        Task<GetGroupInfoResult> GetGroupInfoAsync([JsonNetContent(CharSet = "utf-8")] GetGroupInfoInput input);

        /// <summary>
        /// 分组内添加顾问
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("addguide2guidegroup")]
        Task<ApiResultBase> AddGuide2GuideGroupAsync([JsonNetContent(CharSet = "utf-8")] AddGuide2GuideGroupInput input);

        /// <summary>
        /// 分组内删除顾问
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguide2guidegroup")]
        Task<ApiResultBase> DelGuide2GuideGroupAsync([JsonNetContent(CharSet = "utf-8")] DelGuide2GuideGroupInput input);

        /// <summary>
        /// 获取顾问所在分组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getgroupbyguide")]
        Task<GetGroupByGuideResult> GetGroupByGuideAsync([JsonNetContent(CharSet = "utf-8")] GetGroupByGuideInput input);

        /// <summary>
        /// 删除顾问分组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguidegroup")]
        Task<ApiResultBase> DelGuideGroupAsync([JsonNetContent(CharSet = "utf-8")] DelGuideGroupInput input);

        /// <summary>
        /// 为顾问分配客户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("addguidebuyerrelation")]
        Task<AddGuideBuyerRelationResult> AddGuideBuyerRelationAsync([JsonNetContent(CharSet = "utf-8")] AddGuideBuyerRelationInput input);

        /// <summary>
        /// 为顾问移除客户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguidebuyerrelation")]
        Task<DelGuideBuyerRelationResult> DelGuideBuyerRelationAsync([JsonNetContent(CharSet = "utf-8")] DelGuideBuyerRelationInput input);

        /// <summary>
        /// 获取顾问的客户列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidebuyerrelationlist")]
        Task<GetGuideBuyerRelationListResult> GetGuideBuyerRelationListAsync([JsonNetContent(CharSet = "utf-8")] GetGuideBuyerRelationListInput input);

        /// <summary>
        /// 为客户更换顾问
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("rebindguideacctforbuyer")]
        Task<RebindGuideAcctForBuyerResult> RebindGuideAcctForBuyerAsync([JsonNetContent(CharSet = "utf-8")] RebindGuideAcctForBuyerInput input);

        /// <summary>
        /// 修改客户昵称
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("updateguidebuyerrelation")]
        Task<ApiResultBase> UpdateGuideBuyerRelationAsync([JsonNetContent(CharSet = "utf-8")] UpdateGuideBuyerRelationInput input);

        /// <summary>
        /// 查询客户所属顾问
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidebuyerrelationbybuyer")]
        Task<GetGuideBuyerRelationByBuyerResult> GetGuideBuyerRelationByBuyerAsync([JsonNetContent(CharSet = "utf-8")] GetGuideBuyerRelationByBuyerInput input);

        /// <summary>
        /// 查询指定顾问和客户的关系
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidebuyerrelation")]
        Task<GetGuideBuyerRelationResult> GetGuideBuyerRelationAsync([JsonNetContent(CharSet = "utf-8")] GetGuideBuyerRelationInput input);
    }
}