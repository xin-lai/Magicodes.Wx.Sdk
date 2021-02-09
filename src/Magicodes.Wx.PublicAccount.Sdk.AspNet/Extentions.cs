using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet
{
    public static class Extentions
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServerMessageHandler(this IServiceCollection services)
        {
            services.AddSingleton<ServerMessageHandler>();
            return services;
        }
    }
}