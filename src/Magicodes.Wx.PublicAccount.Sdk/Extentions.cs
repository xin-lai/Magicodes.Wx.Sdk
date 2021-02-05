using Magicodes.Wx.PublicAccount.Sdk.Apis;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Menu;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Message;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Sns;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Token;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Magicodes.Wx.PublicAccount.Sdk
{
    public static class Extentions
    {
        public static void AddMagicodesWeChatSdk(this IServiceCollection services, Action<WxPublicAccountOption> setupAction = null)
        {
            services
                .AddWebApiClient()
                .UseJsonFirstApiActionDescriptor();

            services.AddSingleton<WxFuncs>();
            services.AddHttpApi<ITokenApi>();
            services.AddHttpApi<IOauth2Api>();
            services.AddHttpApi<ISnsApi>();
            services.AddHttpApi<ITemplateApi>();
            services.AddHttpApi<IMenuApi>();
            services.AddSingleton<ITokenManager, TokenManager>();
        }

        public static void UseMagicodesWeChatSdk(this IApplicationBuilder app, Action<WxFuncs> setupAction = null)
        {
            WxFuncs funcs = app.ApplicationServices.GetRequiredService<WxFuncs>();
            setupAction?.Invoke(funcs);
            //如果没有设置获取微信配置逻辑，则自动从配置文件读取
            if (funcs.GetWeChatOptions == null)
            {
                IConfiguration config = app.ApplicationServices.GetRequiredService<IConfiguration>();
                IConfigurationSection wechatConfig = config.GetSection("Wx");
                if (wechatConfig != null)
                {
                    funcs.GetWeChatOptions = () => WxHelper.GetWeChatOptionsByConfiguration(config);
                }
            }
        }

        /// <summary>
        /// 确保成功执行
        /// </summary>
        /// <param name="apiResult"></param>
        public static void EnsureSuccess(this ApiResultBase apiResult)
        {
            if (!apiResult.IsSuccess())
            {
                throw new WxSdkException(apiResult.GetFriendlyMessage());
            }
        }
    }
}