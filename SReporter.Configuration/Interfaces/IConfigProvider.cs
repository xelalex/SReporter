using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;

namespace SReporter.Configuration.Interfaces
{
    public interface IConfigProvider
    {
        SmtpSection Smtp { get; }
        IEnumerable<string> EmailRecipients { get; }
        MailAddress EmailSender { get; }
        MailPriority MailPriority { get; }
        bool IsHtml { get; }
        string SenderName { get; }
        SmtpClient SmtpClient { get; }
    }
}
