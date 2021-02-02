using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace Magicodes.WeChat.Sdk.Apis.CustomerService
{
    [HttpHost("https://api.weixin.qq.com/customservice/kfaccount")]
    [AccessTokenApiFilter]
    public interface IKfAccountApi : IWeChatApiWithAccessTokenFilter
    {
        /// <summary>
        /// 添加客服账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("add")]
        Task<ApiResultBase> AddAsync(AddOrUpdateKfAccountInput input);

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
