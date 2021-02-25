using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.Test
{
    /// <summary>
    /// 公众号事件消息处理程序
    /// </summary>
    public class TestWxEventsHandler : IWxEventsHandler
    {
        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="fromMessage"></param>
        /// <returns></returns>
        public async Task<ToMessageBase> Execute(IFromMessage fromMessage)
        {
            if (fromMessage is FromTextMessage)
            {
                //返回多图文
                var toMsg = new ToNewsMessage()
                {
                    Articles = new List<ToNewsMessage.ArticleInfo>()
                    {
                        new ToNewsMessage.ArticleInfo()
                        {
                            Description = "最简洁最易于使用的微信Sdk，包括公众号Sdk、小程序Sdk、企业微信Sdk等，以及Abp VNext集成。",
                            PicUrl = "https://www.xin-lai.com/imgs/xinlai-logo_9d2c29c2794e6a173738bf92b056ab69.png",
                            Title="Magicodes.Wx.Sdk简介",
                            Url = "http://xin-lai.com"
                        }
                    },
                    FromUserName = "Test",
                    ToUserName = "Test"
                };
                return await Task.FromResult(toMsg);
            }
            else if (fromMessage is FromSubscribeEvent)
            {
                //返回文本消息
                return await Task.FromResult(new ToTextMessage()
                {
                    Content = "欢迎关注!",
                });
            }
            else if (fromMessage is FromTextMessage)
            {
                //返回文本
                return await Task.FromResult(new ToTextMessage()
                {
                    Content = "Test",
                });
            }
            return await Task.FromResult(new ToNullMessage());
        }
    }
}