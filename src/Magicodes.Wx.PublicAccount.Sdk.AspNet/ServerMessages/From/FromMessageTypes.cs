// ======================================================================
//  
//          Copyright (C) 2018-2068 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : FromMessageTypes.cs
//          description :
//  
//          created by codelove1314@live.cn at  2021-02-09 10:48:27
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// =======================================================================

namespace Magicodes.Wx.PublicAccount.Sdk.AspNet.ServerMessages.From
{
    /// <summary>
    ///     接受消息类型
    /// </summary>
    public enum FromMessageTypes
    {
        /// <summary>
        ///     文本
        /// </summary>
        text = 0,
        /// <summary>
        ///     图片
        /// </summary>
        image = 1,
        /// <summary>
        ///     语音
        /// </summary>
        voice = 2,
        /// <summary>
        ///     视频
        /// </summary>
        video = 3,
        /// <summary>
        ///     小视频
        /// </summary>
        shortvideo = 4,
        /// <summary>
        ///     位置
        /// </summary>
        location = 5,
        /// <summary>
        ///     链接
        /// </summary>
        link = 6
    }
}
