using Xunit;
using System.Threading.Tasks;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Token;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Message;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class TemplateApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly ITemplateApi templateApi;
        private readonly WxFuncs weChatFuncs;
        public TemplateApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            templateApi = GetRequiredService<ITemplateApi>();
            weChatFuncs = GetRequiredService<WxFuncs>();
        }

        [Fact]
        public async Task SendAsync_Test()
        {
            var result = await templateApi.SendAsync(new SendTemplateMessageInput()
            {
                To = "oXELNwzZgamuLS0JrJhVgdelzKyw",
                TemplateId = "riid7aad8OKRQD9Ey6dclWBBkrqZSFDhlpKh0_spGLA",
                Data = new System.Collections.Generic.Dictionary<string, TemplateDataItem>()
                {
                    {"first",new TemplateDataItem("测试") },
                    {"keyword1",new TemplateDataItem("雪雁") },
                    {"keyword2",new TemplateDataItem("2021.2.5") },
                    {"remark",new TemplateDataItem("备注") },
                }
            });
            result.EnsureSuccess();
        }


        [Fact]
        public async Task SetIndustryAsync_Test()
        {
            var result = await templateApi.SetIndustryAsync(new SetIndustryInput()
            {
                IndustryId1 = "1",
                IndustryId2 = "4"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetIndustryAsync_Test()
        {
            var result = await templateApi.GetIndustryAsync();
            result.EnsureSuccess();
        }
        [Fact]
        public async Task GetTemplateIdAsync_Test()
        {
            var result = await templateApi.GetTemplateIdAsync(new GetTemplateIdInput()
            {
                TemplateIdShort = "TM00015"

            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetAllPrivateTemplateAsync_Test()
        {
            var result = await templateApi.GetAllPrivateTemplateAsync();
            result.EnsureSuccess();
        }


        [Fact]
        public async Task DelPrivateTemplateAsync_Test()
        {
            var result = await templateApi.DelPrivateTemplateAsync(new DelPrivateTemplateInput()
            {
                TemplateId = "Z5V2PJ7rOsAz_Ypkjk90WdU5ASm1y0jHggz2EIO46So"
            });
            result.EnsureSuccess();
        }
    }
}
