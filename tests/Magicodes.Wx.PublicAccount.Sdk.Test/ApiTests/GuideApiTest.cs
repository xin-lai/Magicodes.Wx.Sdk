using Magicodes.Wx.PublicAccount.Sdk.Apis.Guide;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Guide.Dtos;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class GuideApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly IGuideApi guideApi;

        public GuideApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            guideApi = GetRequiredService<IGuideApi>();
        }

        [Fact]
        public async Task CreateAsync_Test()
        {
            var result = await guideApi.AddGuideAcctAsync(new AddGuideAcctInput
            {
                GuideAccount = "wx_account",
                GuideHeadImgUrl = "xxxxxxx",
                GuideNickName = "张三"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideAcctAsync_Test()
        {
            var result = await guideApi.GetGuideAcctAsync(new GetGuideAcctInput
            {
                GuideAccount = "张三"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task UpdateGuideAcctAsync_Test()
        {
            var result = await guideApi.UpdateGuideAcctAsync(new UpdateGuideAcctInput
            {
                GuideAccount = "wx_account",
                GuideHeadImgUrl = "xxxxxxx",
                GuideNickName = "张三"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DelGuideAcctAsync_Test()
        {
            var result = await guideApi.DelGuideAcctAsync(new DelGuideAcctApiInput
            {
                GuideAccount = "wx_account"
            });
            result.EnsureSuccess();
        }
    }
}