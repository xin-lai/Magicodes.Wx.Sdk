using System;
using System.Runtime.Serialization;

namespace Magicodes.WeChat.Sdk
{
    [Serializable]
    internal class WeChatSdkException : Exception
    {
        public WeChatSdkException()
        {
        }

        public WeChatSdkException(string message) : base(message)
        {
        }

        public WeChatSdkException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeChatSdkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}