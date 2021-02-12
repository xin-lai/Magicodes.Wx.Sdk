using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.Test
{
    public class TestWxEventsHandler : IWxEventsHandler
    {
        public async Task<ToMessageBase> Execute(IFromMessage fromMessage)
        {
            if (fromMessage is FromTextMessage)
            {
                var toMsg = new ToNewsMessage()
                {
                    Articles = new List<ToNewsMessage.ArticleInfo>()
                    {
                        new ToNewsMessage.ArticleInfo()
                        {
                            Description = "湖南心莱信息科技有限公司是由一群从北上广回归的精英携手创建的一家专注软件开发的公司，公司成员基本上都有从事软件开发5年以上的工作经验，并且均领导实施过中大型软件项目。公司以“踏实，直率相处，乐于助人；对技术满怀热情；致力于帮助客户带来价值”为核心价值，希望通过专业水平和不懈努力，为中小企业提供优质的软件服务，为中小软件公司提供优质的软件技术服务。",
                            PicUrl = "http://xin-lai.com/PlugIns/Magicodes.Home/wwwroot/unify/img/logo.png",
                            Title="心莱科技官方介绍",
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
                return await Task.FromResult(new ToTextMessage()
                {
                    Content = "Test",
                });
            }
            else if (fromMessage is FromTextMessage)
            {
                return await Task.FromResult(new ToTextMessage()
                {
                    Content = "Test",
                });
            }
            return await Task.FromResult(new ToNullMessage());
        }
    }
}