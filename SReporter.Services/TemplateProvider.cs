using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SReporter.Services.Interfaces;

namespace SReporter.Services
{
    public class TemplateProvider : ITemplateProvider
    {
        #region Templates

        public string GetSubjectTemplate()
        {
            return "Service report for {0}";
        }

        public string GetBodyTemplate()
        {
            return "Hi!\n\nHere's my report for {0}:\n\n" +
                   "Hours - {1}\n\n" +
                   "Thanks.\n\n" +
                   "Best regards,\n" +
                   "{2}";
        }

        #endregion
    }
}
