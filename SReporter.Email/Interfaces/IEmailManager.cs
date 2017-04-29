using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace SReporter.Email.Interfaces
{
    public interface IEmailManager
    {
        void SendEmail(string subject, string message);
    }
}
