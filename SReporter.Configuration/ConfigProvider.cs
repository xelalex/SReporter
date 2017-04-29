using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using SReporter.Configuration.Interfaces;

namespace SReporter.Configuration
{
    public class ConfigProvider : IConfigProvider
    {
        public SmtpSection Smtp
        {
            get
            {
                return ConfigurationManager.GetSection("system.net/mailSettings/smtp") as SmtpSection;
            }
        }

        public IEnumerable<string> EmailRecipients
        {
            get
            {
                var recipients = ConfigurationManager.AppSettings.GetValues("recipients");
                return recipients != null ? recipients[0].Split(new[] {';', ','}, StringSplitOptions.RemoveEmptyEntries).ToList() : null;
            }
        }

        public MailPriority MailPriority
        {
            get
            {
                var mailPriorityConfig = ConfigurationManager.AppSettings["mailPriority"];
                return mailPriorityConfig != null ? (MailPriority) Enum.Parse(typeof (MailPriority), mailPriorityConfig) : MailPriority.Normal;
            }
        }

        public bool IsHtml
        {
            get
            {
                var isHtmlConfig = ConfigurationManager.AppSettings["isHtml"];
                return isHtmlConfig != null && bool.Parse(isHtmlConfig);
            }
        }

        public string SenderName
        {
            get
            {
                return ConfigurationManager.AppSettings["senderName"];;
            }
        }

        public SmtpClient SmtpClient
        {
            get
            {
                return new SmtpClient(Smtp.Network.Host, Smtp.Network.Port);
            }
        }

        public MailAddress EmailSender
        {
            get
            {
                return new MailAddress(Smtp.From);
            }
        }
    }
}