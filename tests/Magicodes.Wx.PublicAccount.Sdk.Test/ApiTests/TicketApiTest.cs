using Magicodes.Wx.PublicAccount.Sdk.Apis.JSSDK;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class TicketApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly ITicketApi ticketApi;

        public TicketApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            ticketApi = GetRequiredService<ITicketApi>();
        }

        [Fact]
        public async Task GetAsync_Test()
        {
            var result = await ticketApi.GetAsync();
            result.EnsureSuccess();
        }
    }
}
