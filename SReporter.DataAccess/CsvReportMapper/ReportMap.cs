using CsvHelper.Configuration;
using SReporter.Object;

namespace SReporter.DataAccess.CsvReportMapper
{
    public sealed class ReportMap : CsvClassMap<Report>
    {
        public ReportMap()
        {
            Map(m => m.Date).Name("Date").TypeConverter<StringDateTimeConverter>();
            Map(m => m.Hours).Name("Hours").TypeConverter<StringTimeSpanConverter>();
        }
    }
}
