using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Settings;

namespace Magicodes.Wx.PublicAccount.Sdk.Abp
{
    public class WxPublicAccountSettingProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            context.Add(
                new SettingDefinition(WxPublicAccountSettingNames.AppId),
                new SettingDefinition(WxPublicAccountSettingNames.AppSecret),
                new SettingDefinition(WxPublicAccountSettingNames.Token),
                new SettingDefinition(WxPublicAccountSettingNames.WeiXinAccount)
            );
        }
    }
}