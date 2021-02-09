using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Wx.PublicAccount.Sdk.Helper
{
    /// <summary>
    /// 微信时间戳转换
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// Defines the STANDARD_TIME_STAMP
        /// </summary>
        private const long STANDARD_TIME_STAMP = 621355968000000000;

        /// <summary>
        /// 转换为时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ConvertToTimeStamp(this DateTime time)
        {
            return (time.ToUniversalTime().Ticks - STANDARD_TIME_STAMP) / 10000000;
        }

        /// <summary>
        /// 转换为时间
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static DateTime ConvertToDateTime(this long timestamp)
        {
            return new DateTime(timestamp * 10000000 + STANDARD_TIME_STAMP).ToLocalTime();
        }
    }
}