using Magicodes.Wx.PublicAccount.Sdk.Apis.User;
using Magicodes.Wx.PublicAccount.Sdk.Apis.User.Dtos;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class TagsApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly ITagsApi tagsApi;

        public TagsApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(
            webApplicationFactory, output)
        {
            tagsApi = GetRequiredService<ITagsApi>();
        }

        [Fact]
        public async Task CreateAsync_Test()
        {
            var result = await tagsApi.CreateAsync(new CreateTagInput
            {
                Tag = new CreateTagModel
                {
                    Name = "Magicodes good"
                }
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetAsync_Test()
        {
            var result = await tagsApi.GetAsync();
            result.EnsureSuccess();
        }

        [Fact]
        public async Task UpdateAsync_Test()
        {
            var result = await tagsApi.UpdateAsync(new UpdateTagInput
            {
                Tag = new UpdateTagInfo
                {
                    Id = 103,
                    Name = "Magicodes good 1"
                }
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task DeleteAsync_Test()
        {
            var result = await tagsApi.DeleteAsync(new DeleteTagInput
            {
                Tag = new DeleteTagInfo
                {
                    Id = 103
                }
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task BatchTaggingAsync_Test()
        {
            var result = await tagsApi.BatchTaggingAsync(new BatchTaggingInput
            {
                OpenIdList = new[] { "o6l4Nv5rjCXOCkbaCDOAmH1Eoxl4" },
                TagId = 102
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task BatchUnTaggingAsync_Test()
        {
            var result = await tagsApi.BatchUnTaggingAsync(new BatchUnTaggingInput
            {
                OpenIdList = new[] { "o6l4Nv5rjCXOCkbaCDOAmH1Eoxl4" },
                TagId = 102
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetIdListAsync_Test()
        {
            var result = await tagsApi.GetIdListAsync(new GetIdListInput
            {
                OpenId = "o6l4Nv5rjCXOCkbaCDOAmH1Eoxl4"
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetBlackListAsync_Test()
        {
            var result = await tagsApi.GetBlackListAsync(new GetBlackListInput
            {
                BeginOpenId = null
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task BatchBlackListAsync_Test()
        {
            var result = await tagsApi.BatchBlackListAsync(new BatchBlackListInput
            {
                OpenIdList = new[] { "o6l4Nv5rjCXOCkbaCDOAmH1Eoxl4" }
            });
            result.EnsureSuccess();
        }

        [Fact]
        public async Task BatchUnBlackListAsync_Test()
        {
            var result = await tagsApi.BatchUnBlackListAsync(new BatchUnBlackListInput
            {
                OpenIdList = new[] { "o6l4Nv5rjCXOCkbaCDOAmH1Eoxl4" }
            });
            result.EnsureSuccess();
        }
    }
}