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
            //serverMessageHandler.HandleFuncs = new Dictionary<Type, Func<ServerMessages.From.IFromMessage, ServerMessages.To.ToMessageBase>>()
            //{
            //    {
            //        typeof(FromTextMessage),
            //        message => new ToTextMessage()
            //        {
            //            Content = "Test",
            //        }
            //    }
            //};

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