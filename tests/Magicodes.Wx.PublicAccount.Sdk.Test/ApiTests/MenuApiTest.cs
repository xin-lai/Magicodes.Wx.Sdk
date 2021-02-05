using Magicodes.Wx.PublicAccount.Sdk.Apis.Menu;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class MenuApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly IMenuApi menuApi;

        public MenuApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            menuApi = GetRequiredService<IMenuApi>();
        }

        [Fact]
        public async Task CreateAsync_Test()
        {
            var result = await menuApi.CreateAsync(new CreateMenuInput()
            {
                Button = new List<MenuButtonBase>()
                {
                    new ClickButton()
                    {
                        Name = "今日歌曲",
                        Key = "V1001_TODAY_MUSIC"
                    },
                    new SubMenuButton()
                    {
                        Name = "菜单",
                        SubButtons = new List<MenuButtonBase>()
                        {
                            new ViewButton()
                            {
                                Name = "搜索",
                                Url = "http://www.soso.com/"
                            },
                            //需关联小程序后
                            //new MiniprogramButton()
                            //{
                            //    Name = "wxa",
                            //    Url = "http://mp.weixin.qq.com",
                            //    AppId = "wx286b93c14bbf93aa",
                            //    Pagepath = "pages/lunar/index"
                            //},
                            new ClickButton()
                            {
                                Name = "赞一下我们",
                                Key = "V1001_GOOD"
                            }
                        }
                    }
                }
            }); ;
            result.EnsureSuccess();
        }

        [Fact]
        public async Task GetAsync_Test()
        {
            var result = await menuApi.GetAsync();
            if (result == null || result.Menu == null || result.Menu.Button.Count == 0)
            {
                await CreateAsync_Test();
            }
            result = await menuApi.GetAsync();
            result.Menu.Button[0].Name.ShouldBe("今日歌曲");
            result.EnsureSuccess();
        }
    }
}
