// ======================================================================
//
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司
//          All rights reserved
//
//          filename : ServerMessageHandler.cs
//          description :
//
//          created by codelove1314@live.cn at  2021-02-09 10:48:31
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages
{
    using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From;
    using Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.To;
    using Magicodes.Wx.PublicAccount.Sdk.Helper;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// 服务器消息处理类
    /// </summary>
    public class ServerMessageHandler
    {
        private readonly WxFuncs wxFuncs;
        private readonly ILogger<ServerMessageHandler> logger;
        private readonly IServiceProvider serviceProvider;

        public ServerMessageHandler(WxFuncs wxFuncs, ILogger<ServerMessageHandler> logger, IServiceProvider serviceProvider)
        {
            this.wxFuncs = wxFuncs;
            this.logger = logger;
            this.serviceProvider = serviceProvider;
        }

        /// <summary>
        /// 检查签名
        /// </summary>
        /// <param name="signature">签名</param>
        /// <param name="timestamp">时间撮</param>
        /// <param name="nonce">The nonce<see cref="string"/></param>
        /// <returns>返回正确的签名</returns>
        public bool CheckSignature(string signature, string timestamp, string nonce)
        {
            var token = wxFuncs.GetWeChatOptions()?.Token;
            if (token == null)
            {
                throw new ArgumentNullException("Token");
            }
            var arr = new[] { token, timestamp, nonce }.OrderBy(z => z).ToArray();
            var arrString = string.Join("", arr);
            var sha1 = SHA1.Create();
            var sha1Arr = sha1.ComputeHash(Encoding.UTF8.GetBytes(arrString));
            var enText = new StringBuilder();
            foreach (var b in sha1Arr)
                enText.AppendFormat("{0:x2}", b);

            return enText.ToString() == signature;
        }

        /// <summary>
        /// 处理消息
        /// </summary>
        /// <param name="xmlStr">XML字符串</param>
        /// <returns>The <see cref="Task{ToMessageBase}"/></returns>
        public async Task<ToMessageBase> HandleMessage(string xmlStr)
        {
            ToMessageBase toMessage = null;

            logger.LogDebug(Environment.NewLine + xmlStr);
            var xmlElement = XElement.Parse(xmlStr);
            var msgTypeElement = xmlElement.Element("MsgType");
            if (string.IsNullOrWhiteSpace(msgTypeElement?.Value))
            {
                throw new WxSdkException("消息类型不能为空");
            }

            var msgType = msgTypeElement.Value.Trim().ToLower();
            //接收的消息
            IFromMessage fromMessage = null;
            //处理结果
            Tuple<ToMessageBase, IFromMessage> resulTuple;
            //处理事件消息
            if (msgType == "event")
            {
                var fromEventTypeElement = xmlElement.Element("Event");

                if (string.IsNullOrWhiteSpace(fromEventTypeElement?.Value)) throw new WxSdkException("事件类型不能为空");
                var fromEvent = fromEventTypeElement.Value.Trim().ToLower();
                //记录日志
                logger.LogDebug("Event " + fromEvent);
                //处理微信服务器事件Key大小写不一致的问题
                xmlStr = xmlStr.Replace("<Event><![CDATA[" + fromEventTypeElement.Value + "]]></Event>", "<Event><![CDATA[" + fromEvent + "]]></Event>");
                var fromEventType = (FromEventTypes)Enum.Parse(typeof(FromEventTypes), fromEvent);
                resulTuple = fromEventType switch
                {
                    FromEventTypes.subscribe => await ExecuteHandler<FromSubscribeEvent>(xmlStr),
                    FromEventTypes.unsubscribe => await ExecuteHandler<FromUnsubscribeEvent>(xmlStr),
                    FromEventTypes.scan => await ExecuteHandler<FromScanEvent>(xmlStr),
                    FromEventTypes.location => await ExecuteHandler<FromLocationEvent>(xmlStr),
                    FromEventTypes.click => await ExecuteHandler<FromClickEvent>(xmlStr),
                    FromEventTypes.view => await ExecuteHandler<FromViewEvent>(xmlStr),
                    FromEventTypes.templatesendjobfinish => await ExecuteHandler<FromTemplateSendJobFinishEvent>(xmlStr),
                    _ => throw new ArgumentOutOfRangeException(),
                };
            }
            else
            {
                //记录日志
                logger.LogDebug(msgType);
                //处理会话消息
                var fromMessageType = (FromMessageTypes)Enum.Parse(typeof(FromMessageTypes), msgType);
                switch (fromMessageType)
                {
                    case FromMessageTypes.text:
                        resulTuple = await ExecuteHandler<FromTextMessage>(xmlStr);
                        break;

                    case FromMessageTypes.image:
                        resulTuple = await ExecuteHandler<FromImageMessage>(xmlStr);
                        break;

                    case FromMessageTypes.voice:
                        resulTuple = await ExecuteHandler<FromVoiceMessage>(xmlStr);
                        break;

                    case FromMessageTypes.video:
                        resulTuple = await ExecuteHandler<FromVideoMessage>(xmlStr);
                        break;

                    case FromMessageTypes.shortvideo:
                        resulTuple = await ExecuteHandler<FromShortVideoMessage>(xmlStr);
                        break;

                    case FromMessageTypes.location:
                        resulTuple = await ExecuteHandler<FromLocationMessage>(xmlStr);
                        break;

                    case FromMessageTypes.link:
                        resulTuple = await ExecuteHandler<FromLinkMessage>(xmlStr);
                        break;

                    default:
                        throw new NotSupportedException("暂不支持类型为[" + msgType + "]的消息类型");
                }
            }

            if (resulTuple != null)
            {
                fromMessage = resulTuple.Item2;
                toMessage = resulTuple.Item1;
            }

            if (toMessage is ToNewsMessage)
            {
                var news = toMessage as ToNewsMessage;
                if (news.Articles.Count > 10)
                    throw new NotSupportedException("图文消息不能超过10条");
                if (news.Articles.Count == 0)
                    throw new WxSdkException("至少需要包含一条图文消息");
                news.ArticleCount = news.Articles.Count;
            }
            if (toMessage is ToNullMessage)
            {
                return null;
            }
            if (toMessage != null && toMessage.CreateTimestamp == default)
            {
                //设置时间戳
                toMessage.CreateTimestamp = toMessage.CreateDateTime.ConvertToTimeStamp();
                toMessage.FromUserName = fromMessage.ToUserName;
                toMessage.ToUserName = fromMessage.FromUserName;
            }

            return await Task.FromResult(toMessage);
        }

        /// <summary>
        /// 执行处理函数
        /// </summary>
        /// <typeparam name="T">接受类型</typeparam>
        /// <param name="xmlStr">XML字符串</param>
        /// <returns></returns>
        private async Task<Tuple<ToMessageBase, IFromMessage>> ExecuteHandler<T>(string xmlStr)
            where T : class, IFromMessage
        {
            ToMessageBase toMessage = null;
            var type = typeof(T);
            var handler = serviceProvider.GetService<IWxEventsHandler>();
            if (handler == null)
            {
                throw new WxSdkException($"接收公众号服务端事件消息需要先注册 {nameof(IWxEventsHandler)} ！");
            }
            
            IFromMessage fromMessage = XmlHelper.DeserializeObject<T>(xmlStr);
            if (fromMessage != null)
                toMessage = await handler.Execute(fromMessage);
            else
                logger.LogWarning($"序列化类型【{type.FullName}】失败");

            return new Tuple<ToMessageBase, IFromMessage>(toMessage, fromMessage);
        }
    }
}