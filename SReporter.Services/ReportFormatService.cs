using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SReporter.Configuration.Interfaces;
using SReporter.Object;
using SReporter.Services.Interfaces;

namespace SReporter.Services
{
    public class ReportFormatService : IReportFormatService
    {
        #region Members

        private readonly ITemplateProvider _templateProvider;
        private readonly IDateTimeFormatter _dateTimeFormatter;
        private readonly IConfigProvider _configProvider;

        #endregion

        #region Constuctors

        public ReportFormatService(ITemplateProvider templateProvider, 
            IDateTimeFormatter dateTimeFormatter, 
            IConfigProvider configProvider)
        {
            if (templateProvider == null)
            {
                throw new NullReferenceException("templateProvider");
            }
            if (dateTimeFormatter == null)
            {
                throw new NullReferenceException("dateTimeFormatter");
            }
            if (configProvider == null)
            {
                throw new NullReferenceException("configProvider");
            }

            _templateProvider = templateProvider;
            _dateTimeFormatter = dateTimeFormatter;
            _configProvider = configProvider;
        }

        #endregion

        #region Services

        public string ReportSubjectFormatter(Report report)
        {
            return string.Format(_templateProvider.GetSubjectTemplate(), _dateTimeFormatter.GetMonthName(report.Date.Month));
        }

        public string ReportBodyFormatter(Report report)
        {
            return string.Format(_templateProvider.GetBodyTemplate(), _dateTimeFormatter.GetMonthName(report.Date.Month), report.Hours, _configProvider.SenderName);
        }

        #endregion
    }
}
