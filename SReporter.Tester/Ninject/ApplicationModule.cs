using System.Data;
using Ninject.Modules;
using SReporter.BL;
using SReporter.BL.Interfaces;
using SReporter.Configuration;
using SReporter.Configuration.Interfaces;
using SReporter.DataAccess;
using SReporter.DataAccess.Interfaces;
using SReporter.Email;
using SReporter.Email.Interfaces;
using SReporter.Services;
using SReporter.Services.Interfaces;

namespace SReporter.Tester.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            //Bind(typeof(IReportManager)).To(typeof(ReportManager));
            Bind(typeof(IReportSender)).To(typeof(ReportSender));
            Bind(typeof(IConfigProvider)).To(typeof(ConfigProvider));
            Bind(typeof(IEmailManager)).To(typeof(EmailManager));
            Bind(typeof(ITemplateProvider)).To(typeof(TemplateProvider));
            Bind(typeof(IDateTimeFormatter)).To(typeof(DateTimeFormatter));
            Bind(typeof(IReportFormatService)).To(typeof(ReportFormatService));
            Bind(typeof(IReportDataGenericRepository<DataSet, DataRow>)).To(typeof(ReportDataXmlRepository));
        }
    }
}
