using Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl.Dtos;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl
{
    /// <summary>
    /// 订阅通知接口
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/wxaapi/newtmpl/")]
    public interface INewTmplApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// addTemplate选用模板
        /// </summary>
        /// <remarks>从公共模板库中选用模板，到私有模板库中</remarks>
        /// <returns></returns>
        [HttpPost("addtemplate")]
        Task<AddTemplateApiResult> AddTemplateAsync([JsonNetContent(CharSet = "utf-8")] AddTemplateInput input);

        /// <summary>
        /// deleteTemplate删除模板
        /// </summary>
        /// <remarks>删除私有模板库中的模板</remarks>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("deltemplate")]
        Task<ApiResultBase> DeleteTemplateAsync([JsonNetContent(CharSet = "utf-8")] DeleteTemplateInput input);

        /// <summary>
        /// getCategory获取公众号类目
        /// </summary>
        /// <remarks>获取公众号所属类目，可用于查询类目下的公共模板</remarks>
        /// <returns></returns>
        [HttpGet("getcategory")]
        Task<GetCategoryApiResult> GetCategoryAsync();

        /// <summary>
        /// 获取模板中的关键词
        /// </summary>
        /// <remarks>获取公共模板下的关键词列表</remarks>
        /// <param name="tid"></param>
        /// <returns></returns>
        [HttpGet("getpubtemplatekeywords")]
        Task<GetPubTemplateKeyWordsByIdApiResult> GetPubTemplateKeyWordsByIdAsync(string tid);

        /// <summary>
        /// 获取类目下的公共模板
        /// </summary>
        /// <remarks>获取类目下的公共模板，可从中选用模板使用</remarks>
        /// <param name="ids">类目 id，多个用逗号隔开</param>
        /// <param name="start">用于分页，表示从 start 开始，从 0 开始计数</param>
        /// <param name="limit">用于分页，表示拉取 limit 条记录，最大为 30</param>
        /// <returns></returns>
        [HttpGet("getpubtemplatetitles")]
        Task<GetPubTemplateTitleListApiResult> GetPubTemplateTitleListAsync(string ids, int start, int limit);

        /// <summary>
        /// 获取私有模板列表
        /// </summary>
        /// <remarks>获取私有的模板列表</remarks>
        /// <returns></returns>
        [HttpGet("gettemplate")]
        Task<GetTemplateListApiResult> GetTemplateListAsync();

        /// <summary>
        /// 发送订阅通知
        /// </summary>
        /// <remarks>发送订阅通知</remarks>
        /// <returns></returns>
        [HttpPost("https://api.weixin.qq.com/cgi-bin/message/subscribe/bizsend")]
        Task<ApiResultBase> SendAsync([JsonNetContent(CharSet = "utf-8")] BizSendInput input);
    }
}