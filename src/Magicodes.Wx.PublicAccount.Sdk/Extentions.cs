using Magicodes.WeChat.Sdk.Apis;
using Magicodes.WeChat.Sdk.Apis.Sns;
using Magicodes.WeChat.Sdk.Apis.Token;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Magicodes.WeChat.Sdk
{
    public static class Extentions
    {
        public static void AddMagicodesWeChatSdk(this IServiceCollection services, Action<WeChatOptions> setupAction = null)
        {
            services
                .AddWebApiClient()
                .UseJsonFirstApiActionDescriptor();

            services.AddSingleton<WeChatFuncs>();
            services.AddHttpApi<ITokenApi>();
            services.AddHttpApi<IOauth2Api>();
            services.AddHttpApi<ISnsApi>();
            services.AddSingleton<ITokenManager, TokenManager>();
        }

        public static void UseMagicodesWeChatSdk(this IApplicationBuilder app, Action<WeChatFuncs> setupAction = null)
        {
            WeChatFuncs funcs = app.ApplicationServices.GetRequiredService<WeChatFuncs>();
            setupAction?.Invoke(funcs);
            //如果没有设置获取微信配置逻辑，则自动从配置文件读取
            if (funcs.GetWeChatOptions == null)
            {
                IConfiguration config = app.ApplicationServices.GetRequiredService<IConfiguration>();
                IConfigurationSection wechatConfig = config.GetSection("WeChat");
                if (wechatConfig != null)
                {
                    funcs.GetWeChatOptions = () =>
                    {
                        return new WeChatOptions()
                        {
                            AppId = wechatConfig["AppId"],
                            AppSecret = wechatConfig["AppSecret"],
                            Token = wechatConfig["Token"],
                            WeiXinAccount = wechatConfig["WeiXinAccount"],
                        };
                    };
                }
            }
        }

        public static void EnsureSuccess(this ApiResultBase apiResult)
        {
            if (!apiResult.IsSuccess())
            {
                throw new WeChatSdkException(apiResult.GetFriendlyMessage());
            }
        }
    }
}