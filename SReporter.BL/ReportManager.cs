using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SReporter.BL.Interfaces;
using SReporter.Email;
using SReporter.Email.Interfaces;
using SReporter.Object;

namespace SReporter.BL
{
    public class ReportManager : IReportManager
    {
        #region Members

        private readonly IReportSender _reportSender;

        #endregion

        #region Constructors

        public ReportManager(IReportSender reportSender)
        {
            if (reportSender == null){ throw new NullReferenceException("reportSender"); }

            _reportSender = reportSender;
        }

        #endregion

        #region Methods

        public void Report()
        {
            var report = new Report()
            {
                Date = new DateTime(2015, 11, 1),
                Hours = new TimeSpan(2, 30, 0)
            };

            _reportSender.Send(report);
        }

        #endregion

    }
}
