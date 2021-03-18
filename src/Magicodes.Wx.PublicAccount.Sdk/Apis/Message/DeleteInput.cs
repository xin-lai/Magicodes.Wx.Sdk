namespace Magicodes.Wx.PublicAccount.Sdk.Apis.Message
{
    public class DeleteInput
    {
        /// <summary>
        /// 发送出去的消息ID
        /// </summary>
        public int msg_id { get; set; }

        /// <summary>
        /// 要删除的文章在图文消息中的位置，第一篇编号为1，该字段不填或填0会删除全部文章
        /// </summary>

        public int article_idx { get; set; }
    }
}