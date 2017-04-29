using SReporter.Object;

namespace SReporter.Services.Interfaces
{
    public interface IReportFormatService
    {
        string ReportBodyFormatter(Report report);
        string ReportSubjectFormatter(Report report);
    }
}
