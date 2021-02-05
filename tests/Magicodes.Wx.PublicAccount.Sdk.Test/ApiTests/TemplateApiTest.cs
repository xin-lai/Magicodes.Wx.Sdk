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
            //var settings = weChatFuncs.GetWeChatOptions();
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
    }
}
