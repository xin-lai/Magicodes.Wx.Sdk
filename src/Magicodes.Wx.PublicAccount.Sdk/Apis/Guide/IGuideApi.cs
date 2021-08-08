using Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos;
using Magicodes.Wx.Sdk.Core;
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

        /// <summary>
        /// 新建标签类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("newguidetagoption")]
        Task<ApiResultBase> NewGuideTagOptionAsync([JsonNetContent(CharSet = "utf-8")] NewGuideTagOptionInput input);

        /// <summary>
        /// 删除标签类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguidetagoption")]
        Task<ApiResultBase> DelGuideTagOptionAsync([JsonNetContent(CharSet = "utf-8")] DelGuideTagOptionInput input);

        /// <summary>
        /// 为标签添加可选值
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("addguidetagoption")]
        Task<ApiResultBase> AddGuideTagOptionAsync([JsonNetContent(CharSet = "utf-8")] AddGuideTagOptionInput input);

        /// <summary>
        /// 获取标签和可选值
        /// </summary>
        /// <returns></returns>
        [HttpPost("getguidetagoption")]
        Task<GetGuideTagOptionResult> GetGuideTagOptionAsync();

        /// <summary>
        /// 为客户设置标签
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("addguidebuyertag")]
        Task<AddGuideBuyerTagResult> AddGuideBuyerTagAsync([JsonNetContent(CharSet = "utf-8")] AddGuideBuyerTagInput input);

        /// <summary>
        /// 查询客户标签
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidebuyertag")]
        Task<GetGuideBuyerTagResult> GetGuideBuyerTagAsync([JsonNetContent(CharSet = "utf-8")] GetGuideBuyerTagInput input);

        /// <summary>
        /// 根据标签值筛选客户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("queryguidebuyerbytag")]
        Task<QueryGuideBuyerByTagResult> QueryGuideBuyerByTagAsync([JsonNetContent(CharSet = "utf-8")] QueryGuideBuyerByTagInput input);

        /// <summary>
        /// 删除客户标签
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguidebuyertag")]
        Task<DelGuideBuyerTagResult> DelGuideBuyerTagAsync([JsonNetContent(CharSet = "utf-8")] DelGuideBuyerTagInput input);

        /// <summary>
        /// 设置自定义客户信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("addguidebuyerdisplaytag")]
        Task<ApiResultBase> AddGuideBuyerDisplayTagAsync([JsonNetContent(CharSet = "utf-8")] AddGuideBuyerDisplayTagInput input);

        /// <summary>
        /// 获取自定义客户信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidebuyerdisplaytag")]
        Task<GetGuideBuyerDisplayTagResult> GetGuideBuyerDisplayTagAsync([JsonNetContent(CharSet = "utf-8")] GetGuideBuyerDisplayTagInput input);

        /// <summary>
        /// 添加群发任务
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("addguidemassendjob")]
        Task<AddGuideMasssendJobResult> AddGuideMasssendJobAsync([JsonNetContent(CharSet = "utf-8")] AddGuideMasssendJobInput input);

        /// <summary>
        /// 获取群发任务列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidemassendjoblist")]
        Task<GetGuideMassendJobListResult> GetGuideMassendJobListAsync([JsonNetContent(CharSet = "utf-8")] GetGuideMassendJobListInput input);

        /// <summary>
        /// 获取指定群发任务信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidemassendjob")]
        Task<GetGuideMassendJobResult> GetGuideMassendJobAsync([JsonNetContent(CharSet = "utf-8")] GetGuideMassendJobInput input);

        /// <summary>
        /// 修改群发任务
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("updateguidemassendjob")]
        Task<ApiResultBase> UpdateGuideMasssendJobAsync([JsonNetContent(CharSet = "utf-8")] UpdateGuideMasssendJobInput input);

        /// <summary>
        /// 取消群发任务
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("cancelguidemassendjob")]
        Task<ApiResultBase> CancelGuideMassendJobAsync([JsonNetContent(CharSet = "utf-8")] CancelGuideMassendJobInput input);

        /// <summary>
        /// 添加小程序卡片素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("setguidecardmaterial")]
        Task<ApiResultBase> SetGuideCardMaterialAsync([JsonNetContent(CharSet = "utf-8")] SetGuideCardMaterialInput input);

        /// <summary>
        /// 查询小程序卡片素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidecardmaterial")]
        Task<GetGuideCardMaterialResult> GetGuideCardMaterialAsync([JsonNetContent(CharSet = "utf-8")] GetGuideCardMaterialInput input);

        /// <summary>
        /// 删除小程序卡片素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguidecardmaterial")]
        Task<ApiResultBase> DelGuideCardMaterialAsync([JsonNetContent(CharSet = "utf-8")] DelGuideCardMaterialInput input);

        /// <summary>
        /// 添加图片素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("setguideimagematerial")]
        Task<ApiResultBase> SetGuideImageMaterialAsync([JsonNetContent(CharSet = "utf-8")] SetGuideImageMaterialInput input);

        /// <summary>
        /// 查询图片素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguideimagematerial")]
        Task<GetGuideImageMaterialResult> GetGuideImageMaterialAsync([JsonNetContent(CharSet = "utf-8")] GetGuideImageMaterialInput input);

        /// <summary>
        /// 删除图片素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguideimagematerial")]
        Task<ApiResultBase> DelGuideImageMaterialAsync([JsonNetContent(CharSet = "utf-8")] DelGuideImageMaterialInput input);

        /// <summary>
        /// 添加文字素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("setguidewordmaterial")]
        Task<ApiResultBase> SetGuideWordMaterialAsync([JsonNetContent(CharSet = "utf-8")] SetGuideWordMaterialInput input);

        /// <summary>
        /// 查询文字素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguidewordmaterial")]
        Task<GetGuideWordMaterialResult> GetGuideWordMaterialAsync([JsonNetContent(CharSet = "utf-8")] GetGuideWordMaterialInput input);

        /// <summary>
        /// 删除文字素材
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguidewordmaterial")]
        Task<ApiResultBase> DelGuideWordMaterialAsync([JsonNetContent(CharSet = "utf-8")] DelGuideWordMaterialInput input);
    }
}