using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace Magicodes.Wx.PublicAccount.Sdk.Test
{
    public abstract class TestBase : IDisposable
    {
        protected readonly TestWebApplicationFactory webApplicationFactory;

        public TestBase(TestWebApplicationFactory webApplicationFactory)
        {
            this.webApplicationFactory = webApplicationFactory;
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
