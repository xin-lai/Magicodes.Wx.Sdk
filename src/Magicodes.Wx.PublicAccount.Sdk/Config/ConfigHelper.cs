using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Wx.PublicAccount.Sdk.Config
{
    public class ConfigHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public static WxPublicAccountOption GetWeChatOptionsByConfiguration(IConfiguration configuration)
        {
            IConfigurationSection wechatConfig = configuration.GetSection(WxConsts.WX_CONFIG_SECTION_KEY);
            if (wechatConfig == null) return null;
            return new WxPublicAccountOption()
            {
                AppId = wechatConfig["AppId"],
                AppSecret = wechatConfig["AppSecret"],
                Token = wechatConfig["Token"],
                WeiXinAccount = wechatConfig["WeiXinAccount"],
            };
        }
    }
}
