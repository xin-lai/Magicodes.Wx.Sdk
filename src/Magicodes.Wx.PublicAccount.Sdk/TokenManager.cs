using Magicodes.Wx.PublicAccount.Sdk.Apis.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Magicodes.Wx.PublicAccount.Sdk
{
    /// <summary>
    /// 公众号AccessToken管理器
    /// </summary>
    public class TokenManager : ITokenManager
    {
        private readonly WxFuncs weChatFuncs;
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        ///
        /// </summary>
        /// <param name="weChatFuncs"></param>
        /// <param name="serviceProvider"></param>
        public TokenManager(WxFuncs weChatFuncs, IServiceProvider serviceProvider)
        {
            this.weChatFuncs = weChatFuncs;
            this.serviceProvider = serviceProvider;
        }

        /// <summary>
        /// 获取Access Token
        /// </summary>
        /// <returns></returns>
        public virtual async Task<string> GetAccessTokenAsync()
        {
            WxPublicAccountOption options = weChatFuncs?.GetWeChatOptions();
            string token =
                "43_Khgm7pmrbB58SNUezNUNjLZQvxkNe7752ovEk5qGOm4ClCT2eYBTYoMFPd10UMgo6if3dA8gNvkWDPRjdkTqP4PyMOs2aZU6hwf4_2o2M5cyHajaZKXon68FLsUJ-FmInongOKStUe0LETvBDFEdBEAXZY";
            //weChatFuncs?.GetAccessTokenByAppId(options?.AppId);
            if (string.IsNullOrEmpty(token))
            {
                ITokenApi tokenApi = serviceProvider.GetService<ITokenApi>();
                TokenApiResult result = await tokenApi.GetAsync(options.AppId, options.AppSecret);
                weChatFuncs?.CacheAccessToken(options.AppId, result.AccessToken);
                return result.AccessToken;
            }
            return token;
        }
    }
}