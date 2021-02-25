using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Magicodes.Wx.PublicAccount.Sdk.AspNet;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.Test;

namespace Magicodes.Wx.PublicAccount.Sdk.Test
{
    public class TestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //注册IWxEventsHandler,如需处理自定义事件消息,请务必实现IWxEventsHandler
            services.AddSingleton<IWxEventsHandler, TestWxEventsHandler>();
            services.AddMPublicAccountSdk()
                .AddDistributedMemoryCache()
                //添加服务器消息事件处理器
                .AddServerMessageHandler();
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