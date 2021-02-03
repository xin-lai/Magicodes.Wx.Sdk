using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace Magicodes.Wx.PublicAccount.Sdk.Abp
{
    public class WxPublicAccountSdkModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMagicodesWeChatSdk();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var cache = context.ServiceProvider.GetRequiredService<IDistributedCache<string>>();

            app.UseMagicodesWeChatSdk(setup =>
            {
                if (setup.GetWeChatOptions == null)
                {
                    setup.GetWeChatOptions = () =>
                    {
                        var settingProvider = app.ApplicationServices.GetRequiredService<ISettingProvider>();
                        var appId = settingProvider.GetOrNullAsync("Wx.AppId").GetAwaiter().GetResult();
                        if (!string.IsNullOrEmpty(appId))
                        {
                            var appSecret = settingProvider.GetOrNullAsync("Wx.AppSecret").GetAwaiter().GetResult();
                            var token = settingProvider.GetOrNullAsync("Wx.Token").GetAwaiter().GetResult();
                            var weiXinAccount = settingProvider.GetOrNullAsync("Wx.WeiXinAccount").GetAwaiter().GetResult();
                            return new WeChatOptions()
                            {
                                AppId = appId,
                                AppSecret = appSecret,
                                Token = token,
                                WeiXinAccount = weiXinAccount,
                            };
                        }
                        else
                        {
                            IConfiguration config = app.ApplicationServices.GetRequiredService<IConfiguration>();
                            return WeChatHelper.GetWeChatOptionsByConfiguration(config);
                        }
                    };
                }
                setup.GetAccessTokenByAppId = (appid) => cache.Get($"AssessToken::{appid}");

                setup.CacheAccessToken = (appid, token) =>
                {
                    cache.Set($"AssessToken::{appid}", token, new Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions()
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(115)
                    });
                };
            });

        }
    }
}
