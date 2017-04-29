using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using SReporter.Configuration;
using SReporter.Configuration.Interfaces;
using SReporter.Email.Interfaces;

namespace SReporter.Email
{
    public class EmailManager : IEmailManager, IDisposable
    {
        #region Members

        private readonly IConfigProvider _configProvider;

        #endregion

        #region Constructors

        public EmailManager(IConfigProvider configProvider)
        {
            if (configProvider == null) { throw new NullReferenceException("configProvider"); }

            _configProvider = configProvider;
        }

        #endregion

        #region Methods

        public void SendEmail(string subject, string message)
        {
            var emailMessage = new MailMessage
            {
                Subject = subject,
                From = _configProvider.EmailSender,
                Body = message,
                IsBodyHtml = _configProvider.IsHtml,
                Priority = _configProvider.MailPriority
            };

            foreach (var recipient in _configProvider.EmailRecipients)
            {
                emailMessage.To.Add(recipient);
            }

            _configProvider.SmtpClient.Send(emailMessage);
        }

        public void Dispose()
        {
            _configProvider.SmtpClient.Dispose();
        }

        #endregion
    }
}
