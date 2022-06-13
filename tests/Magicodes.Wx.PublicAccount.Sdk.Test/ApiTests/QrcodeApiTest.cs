using Magicodes.Wx.PublicAccount.Sdk.Apis.Media;
using Magicodes.Wx.PublicAccount.Sdk.Apis.Qrcode;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientCore.Parameters;
using Xunit;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test.ApiTests
{
    public class QrcodeApiTest : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly IQrcodeApi qrcodeApi;

        public QrcodeApiTest(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            qrcodeApi = GetRequiredService<IQrcodeApi>();
        }

        [Fact]
        public async Task CreateAsync_Test()
        {
            var result = await qrcodeApi.CreateAsync(new QrcodeInput()
            {
                ExpireSeconds = 60 * 10,
                ActionName = "QR_STR_SCENE",
                ActionInfo = new QrcodeInputActionInfo()
                {
                    Scene = new QrcodeInputActionInfoScene()
                    {
                        SceneStr = DateTime.Now.ToString("yyyyMMddhhmmss")
                    }
                }
            });
            result.EnsureSuccess();
            var imgUrl = $"https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket={result.Ticket}";
        }

        [Fact]
        public async Task CreateAsync_Test2()
        {
            var result = await qrcodeApi.CreateAsync(new QrcodeInput(60 * 10, "QR_STR_SCENE", "mytest"));
            result.EnsureSuccess();
            var imgUrl = $"https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket={result.Ticket}";
        }

        [Fact]
        public async Task CreateAsync_Test3()
        {
            var result = await qrcodeApi.CreateAsync(new QrcodeInput(60 * 10, "QR_SCENE", 9527));
            result.EnsureSuccess();
            var imgUrl = $"https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket={result.Ticket}";
        }
    }
}