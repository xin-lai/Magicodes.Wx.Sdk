using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService
{
    /// <summary>
    /// 客服管理
    /// </summary>
    [HttpHost("https://api.weixin.qq.com/customservice/kfaccount")]
    public interface IKfAccountApi : IWxApiWithAccessTokenFilter
    {
        /// <summary>
        /// 添加客服账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("add")]
        Task<ApiResultBase> AddAsync(AddOrUpdateKfAccountInput input);

        /// <summary>
        /// 设置客服信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("update")]
        Task<ApiResultBase> UpdateAsync(AddOrUpdateKfAccountInput input);

        /// <summary>
        /// 删除客服账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("del")]
        Task<ApiResultBase> DelAsync(DelKfAccountInput input);
    }
}
