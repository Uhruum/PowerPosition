﻿namespace Services.Abstractions
{
    public interface IReportService
    {
        void GenerateReport(string pathToCsvFolder);
    }
}
