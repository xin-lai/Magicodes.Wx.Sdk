using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Magicodes.Wx.PublicAccount.Sdk.AspNet;

namespace Magicodes.Wx.PublicAccount.Sdk.Test
{
    public class TestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMagicodesWeChatSdk().AddServerMessageHandler();
        }

        public void Configure(IApplicationBuilder app)
        {
            var cache = new Dictionary<string, string>();
            app.UseMagicodesWeChatSdk(setup =>
            {
                setup.GetWeChatOptions = () =>
                {
                    //测试号
                    return new WxPublicAccountOption()
                    {
                        AppId = "wx941100f605a8c3bd",
                        AppSecret = "ffb2f8569c76f45c5bd667227b2a8c2d"
                    };
                };

                setup.GetAccessTokenByAppId = (appid) =>
                {
                    var key = $"AssessToken::{appid}";
                    return !cache.ContainsKey(key) ? null : cache[key];
                };

                setup.CacheAccessToken = (appid, token) =>
                {
                    cache[$"AssessToken::{appid}"] = token;
                };
            });
        }
    }
}