using System;
using System.Runtime.Serialization;

namespace Magicodes.Wx.PublicAccount.Sdk
{
    [Serializable]
    internal class WxSdkException : Exception
    {
        public WxSdkException()
        {
        }

        public WxSdkException(string message) : base(message)
        {
        }

        public WxSdkException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WxSdkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}