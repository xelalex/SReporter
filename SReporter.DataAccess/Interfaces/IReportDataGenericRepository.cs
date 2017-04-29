namespace SReporter.DataAccess.Interfaces
{
    public interface IReportDataGenericRepository<out T, in TU>
    {
        T GetReports();
        T CreateReports();
        void UpdateReport(TU report);
        void DeleteReport(TU report);
    }
}
