using System;
using System.Data;
using System.IO;
using SReporter.DataAccess.Interfaces;

namespace SReporter.DataAccess
{
    public class ReportDataXmlRepository : IReportDataGenericRepository<DataTable, DataRow>
    {
        private const string FilePathToReports = @"D:\PROJECTS\_demo\SReporter\REPORTS\service_reports.xml";
        private const string NewFilePathToReports = @"D:\PROJECTS\_demo\SReporter\REPORTS\service_reports_new.xml";
        private const int DailyReportsPKIndex = 0;
        private DataTable _reportsCurrentMonthTemplate;

        private DataTable reportsCurrentMonthTemplate
        {
            get
            {
                if (_reportsCurrentMonthTemplate == null)
                {
                    _reportsCurrentMonthTemplate = new DataTable("SReport");

                    _reportsCurrentMonthTemplate.Columns.AddRange(new[]
                    {
                        new DataColumn("Date", typeof (string)),
                        new DataColumn("Time", typeof (string)),
                        new DataColumn("Books", typeof (string)),
                        new DataColumn("Brochures", typeof (string)),
                        new DataColumn("Magazines", typeof (string)),
                        new DataColumn("ReturnVisits", typeof (string))
                    });

                    var daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

                    for (int day = 1; day <= daysInMonth; day++)
                    {
                        var newReportRow = _reportsCurrentMonthTemplate.NewRow();
                        newReportRow["Date"] = day;
                        newReportRow["Time"] = string.Empty;
                        newReportRow["Books"] = string.Empty;
                        newReportRow["Brochures"] = string.Empty;
                        newReportRow["Magazines"] = string.Empty;
                        newReportRow["ReturnVisits"] = string.Empty;
                        _reportsCurrentMonthTemplate.Rows.Add(newReportRow);
                    }
                    return _reportsCurrentMonthTemplate;
                }
                return _reportsCurrentMonthTemplate;
            }
        }

        public DataTable GetReports()
        {
            var dsReports = new DataSet();

            try
            {
                using (var reader = new StreamReader(NewFilePathToReports))
                {
                    dsReports.ReadXml(reader);
                }

                return dsReports.Tables[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable CreateReports()
        {
            try
            {
                using (var file = File.Create(NewFilePathToReports))
                {
                    reportsCurrentMonthTemplate.WriteXml(file);
                }

                return GetReports();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void UpdateReport(DataRow report)
        {
            var dsReports = GetReports();

            dsReports.PrimaryKey = new[] { dsReports.Columns[DailyReportsPKIndex] };
            
            dsReports.Rows.Find(new[] { report[DailyReportsPKIndex] }).ItemArray = report.ItemArray;

            dsReports.AcceptChanges();

            using (var writer = new StreamWriter(NewFilePathToReports))
            {
                dsReports.WriteXml(writer);
            }
        }

        public void DeleteReport(DataRow report)
        {
            throw new NotImplementedException();
        }
    }
}