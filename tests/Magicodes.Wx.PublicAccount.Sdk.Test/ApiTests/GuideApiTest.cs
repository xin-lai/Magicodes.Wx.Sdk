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

        [Fact]
        public async Task GetGuideAcctListAsync_Test()
        {
            var result = await guideApi.GetGuideAcctListAsync(new GetGuideAcctListInput
            {
                Page = 0,
                Num = 10
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GuideCreateQrCodeAsync_Test()
        {
            var result = await guideApi.GuideCreateQrCodeAsync(new GuideCreateQrCodeInput
            {
                GuideAccount = "wx_account",
                GuideOpenId = ""
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideBuyerChatRecordAsync_Test()
        {
            var result = await guideApi.GetGuideBuyerChatRecordAsync(new GetGuideBuyerChatRecordInput
            {
                GuideAccount = "wx_account",
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task SetGuideConfigAsync_Test()
        {
            var result = await guideApi.SetGuideConfigAsync(new SetGuideConfigInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideConfigAsync_Test()
        {
            var result = await guideApi.GetGuideConfigAsync(new GetGuideConfigInput
            {
                GuideAccount = "wx"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task SetGuideAcctConfigAsync_Test()
        {
            var result = await guideApi.SetGuideAcctConfigAsync(new SetGuideAcctConfigInput
            {
                IsDelete = false,
                BlackKeyword = new BlackKeywordInfo
                {
                    Values = new[] { "xt" }
                }
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideAcctConfigAsync_Test()
        {
            var result = await guideApi.GetGuideAcctConfigAsync();
            result.EnsureSuccess();
        }
    }
}