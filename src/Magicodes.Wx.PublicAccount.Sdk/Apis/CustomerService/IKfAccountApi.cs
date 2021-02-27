using System.Threading.Tasks;
using WebApiClientCore.Attributes;

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

    }
}
