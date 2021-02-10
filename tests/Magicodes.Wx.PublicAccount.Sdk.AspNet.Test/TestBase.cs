using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test
{
    public abstract class TestBase : IDisposable
    {
        protected readonly TestWebApplicationFactory webApplicationFactory;
        private readonly ITestOutputHelper output;

        public TestBase(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output)
        {
            this.webApplicationFactory = webApplicationFactory;
            this.output = output;
            this.webApplicationFactory.Output = output;
        }

        public T GetRequiredService<T>()
        {
            return this.webApplicationFactory.Services.GetRequiredService<T>();
        }

        public virtual void Dispose()
        {

        }

    }
}
