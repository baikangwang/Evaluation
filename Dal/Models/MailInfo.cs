using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class MailInfo
    {
        public MailInfo()
        {
            RecipientAddress = new List<string>();
            CC = new List<string>();
            BCC = new List<string>();
        }

        /// <summary>
        /// 收件人地址
        /// </summary>
        public List<string> RecipientAddress { get; set; }

        /// <summary>
        /// 抄送
        /// </summary>
        public List<string> CC { get; set; }

        /// <summary>
        /// 密送
        /// </summary>
        public List<string> BCC { get; set; }

        /// <summary>
        /// 发件人地址
        /// </summary>
        public string SenderAddress { get; set; }

        /// <summary>
        /// 邮件主体
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 邮件标题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 邮件是否是Html格式
        /// </summary>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// SMTP服务地址
        /// </summary>
        public string SmtpHost { get; set; }

        /// <summary>
        /// SMTP服务端口
        /// </summary>
        public int? SmtpPort { get; set; }

        /// <summary>
        /// SMTP服务帐号
        /// </summary>
        public string SmtpAcount { get; set; }

        /// <summary>
        /// SMTP服务密码
        /// </summary>
        public string SmtpPassword { get; set; }
    }
}
