using Xunit;
using System.Threading.Tasks;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Token;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Message;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    /// <summary>
    /// 模板消息单元测试
    /// </summary>
    public class TemplateApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly ITemplateApi templateApi;
        public TemplateApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            //通过父类的GetRequiredService获取到Api
            templateApi = GetRequiredService<ITemplateApi>();
        }

        /// <summary>
        /// 模板消息发送测试
        /// </summary>
        /// <returns></returns>
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
            //判断Api是否调用成功，未成功将抛出异常WxSdkException
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

    }
}
