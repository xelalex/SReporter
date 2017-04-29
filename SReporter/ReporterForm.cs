using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SReporter.DataAccess.Interfaces;

namespace SReporter
{
    public partial class ReporterForm : Form
    {
        private readonly IReportDataGenericRepository<DataTable, DataRow> _reportDataRepository;

        public ReporterForm(IReportDataGenericRepository<DataTable, DataRow> reportDataRepository)
        {
            _reportDataRepository = reportDataRepository;
            InitializeComponent();
        }

        private void ReportTableInit()
        {
            dgvReportsDashboard.AutoGenerateColumns = false;
            dgvReportsDashboard.ColumnCount = 6;

            dgvReportsDashboard.Columns[0].Name = "Date";
            dgvReportsDashboard.Columns[0].DataPropertyName = "Date";
            dgvReportsDashboard.Columns[0].ValueType = typeof(int);
            dgvReportsDashboard.Columns[0].ReadOnly = true;
            dgvReportsDashboard.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvReportsDashboard.Columns[1].Name = "Time";
            dgvReportsDashboard.Columns[1].DataPropertyName = "Time";
            dgvReportsDashboard.Columns[1].ValueType = typeof(TimeSpan);
            dgvReportsDashboard.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvReportsDashboard.Columns[2].Name = "Books";
            dgvReportsDashboard.Columns[2].DataPropertyName = "Books";
            dgvReportsDashboard.Columns[2].ValueType = typeof(int);
            dgvReportsDashboard.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvReportsDashboard.Columns[3].Name = "Brochures";
            dgvReportsDashboard.Columns[3].DataPropertyName = "Brochures";
            dgvReportsDashboard.Columns[3].ValueType = typeof(int);
            dgvReportsDashboard.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvReportsDashboard.Columns[4].Name = "Magazines";
            dgvReportsDashboard.Columns[4].DataPropertyName = "Magazines";
            dgvReportsDashboard.Columns[4].ValueType = typeof(int);
            dgvReportsDashboard.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvReportsDashboard.Columns[5].Name = "ReturnVisits";
            dgvReportsDashboard.Columns[5].DataPropertyName = "ReturnVisits";
            dgvReportsDashboard.Columns[5].ValueType = typeof(int);
            dgvReportsDashboard.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ReporterForm_Load(object sender, EventArgs e)
        {
            ReportTableInit();

            DataTable dtDailyReports = _reportDataRepository.GetReports();

            if (dtDailyReports != null)
            {
                dgvReportsDashboard.DataSource = dtDailyReports;
            }
            else
            {
                var newReportTable = _reportDataRepository.CreateReports();

                dgvReportsDashboard.DataSource = newReportTable;
            }
        }

        //private void dgvReportsDashboard_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    //var modifiedReportRow = ((DataTable)dgvReportsDashboard.DataSource).Rows[e.RowIndex];
            
        //    //_reportDataRepository.UpdateReport(modifiedReportRow);
        //}

        private void dgvReportsDashboard_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReportsDashboard.Columns[e.ColumnIndex].Name == "Date")
            {
                ShortenDateToDay(e);
            }
        }

        private static void ShortenDateToDay(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    DateTime theDate = DateTime.ParseExact(formatting.Value.ToString(), @"dd\/MM\/yy", CultureInfo.InvariantCulture);
                    formatting.Value = theDate.Day.ToString();
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }

        private void dgvReportsDashboard_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var modifiedReportRow = ((DataTable)dgvReportsDashboard.DataSource).Rows[e.RowIndex];

            _reportDataRepository.UpdateReport(modifiedReportRow);
        }
    }
}