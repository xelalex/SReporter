using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.TypeConversion;
using SReporter.DataAccess.CsvReportMapper;
using SReporter.DataAccess.Interfaces;
using SReporter.Object;

namespace SReporter.DataAccess
{
    public class ReportDataCsvRepository : IReportDataGenericRepository<IEnumerable<Report>, Report>
    {
        private const string ReadReportsPath = @"..\..\..\REPORTS\daily_reports.csv";
        private const string WriteReportsPath = @"..\..\..\REPORTS\daily_reports_new.csv";

        public IEnumerable<Report> GetReports()
        {
            List<Report> reports;

            using (var reader = new StreamReader(ReadReportsPath))
            using (var csvReader = new CsvReader(reader))
            {
                csvReader.Configuration.RegisterClassMap<ReportMap>();
                reports = csvReader.GetRecords<Report>().ToList();
            }

            return reports;
        }

        public DataSet GetDataSetReports()
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Report report)
        {
            IEnumerable<Report> reports;

            using (var reader = new StreamReader(ReadReportsPath))
            using (var csvReader = new CsvReader(reader))
            {
                csvReader.Configuration.RegisterClassMap<ReportMap>();
                reports = csvReader.GetRecords<Report>();
            }

            if (reports != null)
            {
                var reportToEdit = reports.Single(r => r.Date == report.Date);
                reportToEdit.Hours = report.Hours;

                if (reportToEdit != null)
                {
                    //reports.Where( s => s.Date == reportToEdit.Date).Select(r =>
                    //{
                    //    r = reportToEdit;
                    //    return r;
                    //}).ToList();
                    
                    using (var writer = new StreamWriter(WriteReportsPath))
                    using (var csvWriter = new CsvWriter(writer))
                    {
                        csvWriter.Configuration.RegisterClassMap<ReportMap>();
                        csvWriter.WriteRecords(GetReports());
                    }
                }
            }
        }

        public IEnumerable<Report> CreateReports()
        {
            using (var writer = new StreamWriter(WriteReportsPath))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.RegisterClassMap<ReportMap>();
                csvWriter.WriteRecords(GetReports());
            }

            return null;
        }

        public void DeleteReport(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
