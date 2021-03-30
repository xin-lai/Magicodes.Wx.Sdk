using Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl;
using Magicodes.Wx.PublicAccount.Sdk.Apis.NewTmpl.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class NewTmplApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly INewTmplApi newTmplApi;

        public NewTmplApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            newTmplApi = GetRequiredService<INewTmplApi>();
        }

        [Fact]
        public async Task AddTemplateAsync_Test()
        {
            var result = await newTmplApi.AddTemplateAsync(new AddTemplateInput
            {
                Tid = "401",
                KidList = new[] { 1, 2 },
                SceneDesc = "测试数据"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DeleteTemplateAsync_Test()
        {
            var result = await newTmplApi.DeleteTemplateAsync(new DeleteTemplateInput
            {
                PriTmplId = "wDYzYZVxobJivW9oMpSCpuvACOfJXQIoKUm0PY397Tc"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetCategoryAsync_Test()
        {
            var result = await newTmplApi.GetCategoryAsync();
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetPubTemplateKeyWordsByIdAsync_Test()
        {
            var result = await newTmplApi.GetPubTemplateKeyWordsByIdAsync("99");
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetPubTemplateTitleListAsync_Test()
        {
            var result = await newTmplApi.GetPubTemplateTitleListAsync("2,616", 0, 1);
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetTemplateListAsync_Test()
        {
            var result = await newTmplApi.GetTemplateListAsync();
            result.EnsureSuccess();
        }

        [Fact]
        public async Task SendAsync_Test()
        {
            var data = new Dictionary<string, NewTmplDataItem>
            {
                { "name1", new NewTmplDataItem("广州腾讯科技有限公司") },
                { "thing8", new NewTmplDataItem("广州腾讯科技有限公司") },
                { "time7", new NewTmplDataItem("2019年8月8日") }
            };
            var result = await newTmplApi.SendAsync(new BizSendInput
            {
                ToUser = "OPENID",
                TemplateId = "TEMPLATEID",
                Page = "mp.weixin.qq.com",
                MiniProgram = new NewTmplMiniProgramInfo
                {
                    AppId = "APPID",
                    PagePath = "index?foo=bar"
                },
                Data = data
            });
            result.EnsureSuccess();
        }
    }
}