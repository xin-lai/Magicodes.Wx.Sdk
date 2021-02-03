using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Token;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class TokenApiTestcs : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly ITokenApi tokenApi;
        private readonly WxFuncs weChatFuncs;
        public TokenApiTestcs(TestWebApplicationFactory webApplicationFactory) : base(webApplicationFactory)
        {
            tokenApi = GetRequiredService<ITokenApi>();
            weChatFuncs = GetRequiredService<WxFuncs>();
        }

        [Fact]
        public async Task GetAsync_Test()
        {
            var settings = weChatFuncs.GetWeChatOptions();
            var result = await tokenApi.GetAsync(settings.AppId,settings.AppSecret);
            result.EnsureSuccess();
        }
    }
}
