using Magicodes.Wx.PublicAccount.Sdk.Apis.CustomerService;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class CustomerApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly IKfAccountApi kfAccountApi;

        public CustomerApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            kfAccountApi = GetRequiredService<IKfAccountApi>();

        }

        [Fact]
        public async Task CreateAsync_Test()
        {
            var result = await kfAccountApi.AddAsync(new AddOrUpdateKfAccountInput()
            {

                Account = "yangshuai@ceshi",
                Nickname = "欧阳"
            }

            );
            result.EnsureSuccess();
        }
    }
}