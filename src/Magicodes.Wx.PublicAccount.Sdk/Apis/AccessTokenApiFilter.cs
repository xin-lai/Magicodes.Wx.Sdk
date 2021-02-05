using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis
{
    public class AccessTokenApiFilter : ApiFilterAttribute
    {
        public override async Task OnRequestAsync(ApiRequestContext context)
        {
            ITokenManager tokenManager = context.HttpContext.ServiceProvider.GetRequiredService<ITokenManager>();
            string accessToken = await tokenManager.GetAccessTokenAsync();
            context.HttpContext.RequestMessage.AddUrlQuery("access_token", accessToken);
            var data = await context.HttpContext.RequestMessage.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(data))
            {
                var logger = context.HttpContext.ServiceProvider.GetRequiredService<ILogger<AccessTokenApiFilter>>();
                logger.LogInformation(data);
            }
        }

        public override Task OnResponseAsync(ApiResponseContext context)
        {
            return Task.CompletedTask;
        }
    }
}
