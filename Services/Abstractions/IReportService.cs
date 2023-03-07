namespace Services.Abstractions
{
    /// <summary>
    /// Service for generation of PowerPosition report
    /// </summary>
    public interface IReportService
    {
        /// <summary>
        /// Generates PowerPosition report on specified path
        /// </summary>
        /// <param name="pathToCsvFolder"></param>
        void GenerateReport(string pathToCsvFolder);
    }
}
