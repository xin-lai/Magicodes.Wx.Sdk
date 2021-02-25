using Magicodes.Wx.PublicAccount.Sdk.AspNet;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Wx.PublicAccount.Sdk.Test
{
    public class TestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //添加公众号Sdk集成
            services.AddMPublicAccountSdk()
                //使用内存缓存
                .AddDistributedMemoryCache();
        }

        public void Configure(IApplicationBuilder app)
        {
            //配置公众号Sdk
            app.UseMPublicAccountSdk()
                //使用分布式缓存缓存Access Token
                .UseWxDistributedCacheForAccessToken();
        }
    }
}