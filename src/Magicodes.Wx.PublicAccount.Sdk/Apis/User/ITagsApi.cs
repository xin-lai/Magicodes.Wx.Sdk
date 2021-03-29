using Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.User
{
    /// <summary>
    /// 用户标签管理
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/cgi-bin/tags/")]
    public interface ITagsApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 1.创建标签
        /// </summary>
        /// <returns></returns>
        [HttpPost("create")]
        Task<CreateTagApiResult> CreateAsync([JsonNetContent(CharSet = "utf-8")] CreateTagInput input);

        /// <summary>
        /// 2.获取公众号已创建的标签
        /// </summary>
        /// <returns></returns>
        [HttpGet("get")]
        Task<GetTagsApiResult> GetAsync();

        /// <summary>
        /// 3.编辑标签
        /// </summary>
        /// <returns></returns>
        [HttpPost("update")]
        Task<ApiResultBase> UpdateAsync([JsonNetContent(CharSet = "utf-8")] UpdateTagInput input);

        /// <summary>
        /// 4.删除标签
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        Task<ApiResultBase> DeleteAsync([JsonNetContent(CharSet = "utf-8")] DeleteTagInput input);

        /// <summary>
        /// 批量为用户打标签
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("members/batchtagging")]
        Task<ApiResultBase> BatchTaggingAsync([JsonNetContent(CharSet = "utf-8")] BatchTaggingInput input);

        /// <summary>
        /// 批量为用户取消标签
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("members/batchuntagging")]
        Task<ApiResultBase> BatchUnTaggingAsync([JsonNetContent(CharSet = "utf-8")] BatchUnTaggingInput input);

        /// <summary>
        /// 获取用户身上的标签列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getidlist")]
        Task<GetIdListApiResult> GetIdListAsync([JsonNetContent(CharSet = "utf-8")] GetIdListInput input);
    }
}