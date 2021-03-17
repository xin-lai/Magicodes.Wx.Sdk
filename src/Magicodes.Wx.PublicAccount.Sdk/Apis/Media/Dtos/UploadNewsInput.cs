using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Media
{
    public class UploadNewsInput
    {
        /// <summary>
        /// 图文消息，一个图文消息支持1到8条图文
        /// </summary>
        [Required]
        public IEnumerable<Article> articles { get; set; }

        public class Article
        {
            /// <summary>
            /// 图文消息缩略图的media_id，可以在素材管理-新增素材中获得
            /// </summary>
            [Required]
            public string thumb_media_id { get; set; }

            /// <summary>
            ///图文消息的作者
            /// </summary>

            public string author { get; set; }

            /// <summary>
            /// 图文消息的标题
            /// </summary>
            [Required]
            public string title { get; set; }

            /// <summary>
            ///在图文消息页面点击“阅读原文”后的页面，受安全限制，如需跳转Appstore，可以使用itun.es或appsto.re的短链服务，并在短链后增加 #wechat_redirect 后缀。
            /// </summary>
            public string content_source_url { get; set; }

            /// <summary>
            /// 图文消息页面的内容，支持HTML标签。具备微信支付权限的公众号，可以使用a标签，其他公众号不能使用，如需插入小程序卡片，可参考下文。
            /// </summary>
            [Required]
            public string content { get; set; }

            /// <summary>
            /// 图文消息的描述，如本字段为空，则默认抓取正文前64个字
            /// </summary>
            public string digest { get; set; }

            /// <summary>
            /// 是否显示封面，1为显示，0为不显示
            /// </summary>
            public int show_cover_pic { get; set; }

            /// <summary>
            /// Uint32 是否打开评论，0不打开，1打开
            /// </summary>
            public int need_open_comment { get; set; }

            /// <summary>
            /// Uint32 是否粉丝才可评论，0所有人可评论，1粉丝才可评论
            /// </summary>
            public int only_fans_can_comment { get; set; }
        }
    }
}