using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SReporter.BL;
using SReporter.BL.Interfaces;
using SReporter.DataAccess;
using SReporter.DataAccess.Interfaces;
using SReporter.Email;
using SReporter.Email.Interfaces;
using SReporter.Object;
using SReporter.Tester.Ninject;

namespace SReporter.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositionRoot.Wire(new ApplicationModule());
           // var reportManager = new ReportManager(CompositionRoot.Resolve<IReportSender>());

            //var reportDataManager = CompositionRoot.Resolve<IDataRepository>();

            //reportDataManager.SaveReports();

            //var date = new DateTime(2015, 10, 19);
            //reportDataManager.UpdateReportByDate(date, new Report()
            //{
            //    Date = date,
            //    Hours = new TimeSpan(70, 0, 0)
            //});

            //var test = reportDataManager.GetReports();

            //Console.WriteLine("Date " + "\t\t\tHours");
            //foreach (var report in reportDataManager.GetReports())
            //{
            //    Console.WriteLine(report.Date + " \t" + report.Hours);
            //}

            Console.ReadLine();


            //reportManager.Report();

            // 27 hours, 24 minutes, 2 seconds
            //TimeSpan span2 = new TimeSpan(27, 24, 2);

            //string format2 = span2.ToString(@"hh\:mm");
            //Console.WriteLine(format2);
            //Console.ReadLine();
        }
    }
}
