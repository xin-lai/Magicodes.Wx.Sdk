using Magicodes.Wx.PublicAccount.Sdk.Apis.User;
using Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class UserApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly IUserApi userApi;

        public UserApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            userApi = GetRequiredService<IUserApi>();
        }

        [Fact]
        public async Task InfoAsync_Test()
        {
            var result = await userApi.InfoAsync("007");
            result.EnsureSuccess();
        }

        [Fact]
        public async Task UpdateRemarkAsync_Test()
        {
            var result = await userApi.UpdateRemarkAsync(new UpdateRemarkInput
            {
                OpenId = "oDF3iY9ffA-hqb2vVvbr7qxf6A0Q",
                Remark = "Magicodes"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetAsync_Test()
        {
            var result = await userApi.GetAsync();
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetUserByTagAsync_Test()
        {
            var result = await userApi.GetUserByTagAsync(new GetUserByTagInput
            {
                TagId = 103,
                NextOpenId = string.Empty
            });
            result.EnsureSuccess();
        }
    }
}