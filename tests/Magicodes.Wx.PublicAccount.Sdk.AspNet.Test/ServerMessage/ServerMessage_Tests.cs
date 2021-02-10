using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From;
using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To;
using Magicodes.Wx.PublicAccount.Sdk.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Shouldly;
using System.Xml.Linq;

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.Test.ServerMessage
{
    public class ServerMessage_Tests : TestBase, IClassFixture<TestWebApplicationFactory>
    {
        private readonly ServerMessageHandler serverMessageHandler;

        public ServerMessage_Tests(TestWebApplicationFactory webApplicationFactory, ITestOutputHelper output) : base(webApplicationFactory, output)
        {
            serverMessageHandler = GetRequiredService<ServerMessageHandler>();
        }

        [Fact]
        public void HandleMessage_Test()
        {
            serverMessageHandler.HandleFuncs = new Dictionary<Type, Func<ServerMessages.From.IFromMessage, ServerMessages.To.ToMessageBase>>()
            {
                {
                    typeof(FromTextMessage),
                    message => new ToTextMessage()
                    {
                        Content = "Test",
                    }
                }
            };

            var tomsg = serverMessageHandler.HandleMessage(
                 @"<xml>
                     <ToUserName><![CDATA[toUser]]></ToUserName>
                     <FromUserName><![CDATA[fromUser]]></FromUserName>
                     <CreateTime>1348831860</CreateTime>
                     <MsgType><![CDATA[text]]></MsgType>
                     <Content><![CDATA[this is a test]]></Content>
                     <MsgId>1234567890123456</MsgId>
                </xml>").Result;
            (tomsg.CreateDateTime == default).ShouldBeFalse("时间格式错误!");
            tomsg.ToUserName.ShouldBe("fromUser", "用户解析错误！");
            var xml = tomsg.ToXml();
            xml.ShouldNotBeNullOrWhiteSpace("Xml序列化错误！");
        }

        [Fact]
        public async Task FromSubscribeEvent_HandleMessageTest()
        {
            serverMessageHandler.HandleFuncs = new Dictionary<Type, Func<IFromMessage, ToMessageBase>>()
                {
                    {
                        typeof(FromSubscribeEvent),
                        message => new ToTextMessage()
                        {
                            Content = "Test",
                        }
                    }
                };
            var tomsg = await serverMessageHandler.HandleMessage(
                 @"<xml><ToUserName><![CDATA[gh_44ab71bac0b5]]></ToUserName>
                    <FromUserName><![CDATA[owQ_nw9_ZA8uGdqWYp1ckdFQ6aeo]]></FromUserName>
                    <CreateTime>1504084003</CreateTime>
                    <MsgType><![CDATA[event]]></MsgType>
                    <Event><![CDATA[subscribe]]></Event>
                    <EventKey><![CDATA[]]></EventKey>
                    </xml>");
            (tomsg.CreateDateTime == default).ShouldBeFalse("时间格式错误!");
            tomsg.ToUserName.ShouldBe("owQ_nw9_ZA8uGdqWYp1ckdFQ6aeo", "用户解析错误！");
            var xml = tomsg.ToXml();
            xml.ShouldNotBeNullOrWhiteSpace("Xml序列化错误！");
        }

        [Fact]
        public void ToMessageXmlTest()
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
            serverMessageHandler.HandleFuncs = new Dictionary<Type, Func<IFromMessage, ToMessageBase>>()
                {
                    {
                        typeof(FromTextMessage),
                        message => toMsg
                    }
                };
            var result = serverMessageHandler.HandleMessage(
                @"<xml>
                     <ToUserName><![CDATA[toUser]]></ToUserName>
                     <FromUserName><![CDATA[fromUser]]></FromUserName>
                     <CreateTime>1348831860</CreateTime>
                     <MsgType><![CDATA[text]]></MsgType>
                     <Content><![CDATA[this is a test]]></Content>
                     <MsgId>1234567890123456</MsgId>
                </xml>").Result;
            var xmlStr = result.ToXml();
            var xEle = XElement.Parse(xmlStr);
            xEle.Element("Articles").ShouldNotBeNull("图文格式有误！");
        }
    }
}