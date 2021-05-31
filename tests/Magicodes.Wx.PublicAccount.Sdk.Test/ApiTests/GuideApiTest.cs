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

        [Fact]
        public async Task PushShowWxaPathMenuAsync_Test()
        {
            var result = await guideApi.PushShowWxaPathMenuAsync(new PushShowWxaPathMenuInput
            {
                WxaAppid = "",
                WxUserName = ""
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task NewGuideGroupAsync_Test()
        {
            var result = await guideApi.NewGuideGroupAsync(new NewGuideGroupInput
            {
                GroupName = "Magicodes"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideGroupListAsync_Test()
        {
            var result = await guideApi.GetGuideGroupListAsync();
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGroupInfoAsync_Test()
        {
            var result = await guideApi.GetGroupInfoAsync(new GetGroupInfoInput
            {
                GroupId = 1,
                Page = 1,
                Num = 10
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task AddGuide2GuideGroupAsync_Test()
        {
            var result = await guideApi.AddGuide2GuideGroupAsync(new AddGuide2GuideGroupInput
            {
                GroupId = 1,
                GuideAccount = "1"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DelGuide2GuideGroupAsync_Test()
        {
            var result = await guideApi.DelGuide2GuideGroupAsync(new DelGuide2GuideGroupInput
            {
                GroupId = 1,
                GuideAccount = "1"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGroupByGuideAsync_Test()
        {
            var result = await guideApi.GetGroupByGuideAsync(new GetGroupByGuideInput
            {
                GuideAccount = "wx"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DelGuideGroupAsync_Test()
        {
            var result = await guideApi.DelGuideGroupAsync(new DelGuideGroupInput
            {
                GroupId = 1
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task AddGuideBuyerRelationAsync_Test()
        {
            var result = await guideApi.AddGuideBuyerRelationAsync(new AddGuideBuyerRelationInput
            {
                GuideAccount = "wx",
                GuideOpenId = "magicodes"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DelGuideBuyerRelationAsync_Test()
        {
            var result = await guideApi.DelGuideBuyerRelationAsync(new DelGuideBuyerRelationInput
            {
                GuideAccount = "wx",
                GuideOpenId = "magicodes"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideBuyerRelationListAsync_Test()
        {
            var result = await guideApi.GetGuideBuyerRelationListAsync(new GetGuideBuyerRelationListInput
            {
                GuideAccount = "wx",
                GuideOpenId = "magicodes",
                Page = 1,
                Num = 20
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task RebindGuideAcctForBuyerAsync_Test()
        {
            var result = await guideApi.RebindGuideAcctForBuyerAsync(new RebindGuideAcctForBuyerInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task UpdateGuideBuyerRelationAsync_Test()
        {
            var result = await guideApi.UpdateGuideBuyerRelationAsync(new UpdateGuideBuyerRelationInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideBuyerRelationByBuyerAsync_Test()
        {
            var result = await guideApi.GetGuideBuyerRelationByBuyerAsync(new GetGuideBuyerRelationByBuyerInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideBuyerRelationAsync_Test()
        {
            var result = await guideApi.GetGuideBuyerRelationAsync(new GetGuideBuyerRelationInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task NewGuideTagOptionAsync_Test()
        {
            var result = await guideApi.NewGuideTagOptionAsync(new NewGuideTagOptionInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DelGuideTagOptionAsync_Test()
        {
            var result = await guideApi.DelGuideTagOptionAsync(new DelGuideTagOptionInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task AddGuideTagOptionAsync_Test()
        {
            var result = await guideApi.AddGuideTagOptionAsync(new AddGuideTagOptionInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideTagOptionAsync_Test()
        {
            var result = await guideApi.GetGuideTagOptionAsync();
            result.EnsureSuccess();
        }

        [Fact]
        public async Task AddGuideBuyerTagAsync_Test()
        {
            var result = await guideApi.AddGuideBuyerTagAsync(new AddGuideBuyerTagInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideBuyerTagAsync_Test()
        {
            var result = await guideApi.GetGuideBuyerTagAsync(new GetGuideBuyerTagInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task QueryGuideBuyerByTagAsync_Test()
        {
            var result = await guideApi.QueryGuideBuyerByTagAsync(new QueryGuideBuyerByTagInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DelGuideBuyerTagAsync_Test()
        {
            var result = await guideApi.DelGuideBuyerTagAsync(new DelGuideBuyerTagInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task AddGuideBuyerDisplayTagAsync_Test()
        {
            var result = await guideApi.AddGuideBuyerDisplayTagAsync(new AddGuideBuyerDisplayTagInput
            {
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetGuideBuyerDisplayTagAsync_Test()
        {
            var result = await guideApi.GetGuideBuyerDisplayTagAsync(new GetGuideBuyerDisplayTagInput { });
            result.EnsureSuccess();
        }
    }
}