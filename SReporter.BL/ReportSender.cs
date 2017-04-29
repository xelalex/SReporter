using System;
using SReporter.BL.Interfaces;
using SReporter.Email.Interfaces;
using SReporter.Object;
using SReporter.Services.Interfaces;

namespace SReporter.BL
{
    public class ReportSender : IReportSender
    {
        #region Members

        private readonly IEmailManager _emailManager;
        private readonly IReportFormatService _reportFormatService;

        #endregion

        #region Constructors

        public ReportSender(IEmailManager emailManager, 
            IReportFormatService reportFormatService)
        {
            if (emailManager == null) { throw new NullReferenceException("emailManager"); }
            if (reportFormatService == null) { throw new NullReferenceException("reportFormatService"); }

            _emailManager = emailManager;
            _reportFormatService = reportFormatService;
        }

        #endregion

        #region Methods

        public void Send(Report report)
        {
            var reportSubject = _reportFormatService.ReportSubjectFormatter(report);
            var reportMessage = _reportFormatService.ReportBodyFormatter(report);

            _emailManager.SendEmail(reportSubject, reportMessage);
        }

        #endregion
    }
}
