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
        Task<ApiResultBase> AddGuideAcctAsync(AddGuideAcctInput input);

        /// <summary>
        /// 获取顾问信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("getguideacct")]
        Task<GetGuideAcctApiResult> GetGuideAcctAsync(GetGuideAcctInput input);

        /// <summary>
        /// 修改顾问的昵称或头像
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("updateguideacct")]
        Task<ApiResultBase> UpdateGuideAcctAsync(UpdateGuideAcctInput input);

        /// <summary>
        /// 删除顾问
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("delguideacct")]
        Task<ApiResultBase> DelGuideAcctAsync(DelGuideAcctApiInput input);
    }
}