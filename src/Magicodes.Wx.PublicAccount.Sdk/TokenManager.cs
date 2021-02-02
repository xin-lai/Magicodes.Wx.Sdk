using Magicodes.WeChat.Sdk.Apis.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Magicodes.WeChat.Sdk
{
    public class TokenManager : ITokenManager
    {
        private readonly WeChatFuncs weChatFuncs;
        private readonly IServiceProvider serviceProvider;

        public TokenManager(WeChatFuncs weChatFuncs, IServiceProvider serviceProvider)
        {
            this.weChatFuncs = weChatFuncs;
            this.serviceProvider = serviceProvider;
        }

        public virtual async Task<string> GetAccessTokenAsync()
        {
            WeChatOptions options = weChatFuncs?.GetWeChatOptions();
            string token = weChatFuncs?.GetAccessTokenByAppId(options?.AppId);
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
