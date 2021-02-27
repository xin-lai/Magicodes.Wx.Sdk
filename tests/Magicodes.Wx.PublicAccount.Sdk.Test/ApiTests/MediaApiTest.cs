using Magicodes.Wx.PublicAccount.Sdk.Apis.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientCore.Parameters;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class MediaApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly IMediaApi mediaApi;

        public MediaApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            mediaApi = GetRequiredService<IMediaApi>();
        }

        [Fact]
        public async Task UploadAsync_Test()
        {
            var file = new FormDataFile("Media/wechat.jpg");
            var result = await mediaApi.UploadAsync("image", file);
            result.EnsureSuccess();
        }
    }
}
