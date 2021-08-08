using Magicodes.Wx.Sdk.Core;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    /// <summary>
    /// 客服管理
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/customservice/")]
    public interface IKfAccountApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 添加客服账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("kfaccount/add")]
        Task<ApiResultBase> AddAsync(AddOrUpdateKfAccountInput input);

        /// <summary>
        /// 设置客服信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("kfaccount/update")]
        Task<ApiResultBase> UpdateAsync(AddOrUpdateKfAccountInput input);

        /// <summary>
        /// 删除客服账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("kfaccount/del")]
        Task<ApiResultBase> DelAsync(DelKfAccountInput input);

        /// <summary>
        /// 获取客服基本信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("getkflist")]
        Task<GetKFListResult> GetKFListAsync();

        /// <summary>
        /// 获取在线客服接待会话数
        /// </summary>
        /// <returns></returns>
        [HttpGet("getonlinekflist")]
        Task<GetOnlineKFListResult> GetOnlineKFListAsync();

        /// <summary>
        /// 邀请绑定客服帐号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("kfaccount/inviteworker")]
        Task<ApiResultBase> InviteWorkerAsync(InviteWorkerInput input);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="kf_account">完整客服帐号，格式为：帐号前缀@公众号微信号</param>
        /// <param name="media">form-data 中媒体文件标识，有filename、filelength、content-type 等信息，文件大小为5M 以内</param>
        /// <returns></returns>
        [HttpPost("kfaccount/uploadheadimg")]
        Task<ApiResultBase> UploadHeadimg([Required] string kf_account, FormDataFile media);
    }
}
