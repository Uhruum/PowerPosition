using CsvHelper;
using Domain.Models;
using Services.Abstractions;
using Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Services.Implementations
{
    public class CsvGenerator : ICsvGenerator
    {
        public void Generate(IEnumerable<TradeItem> items, string path)
        {
            string fileName = $"PowerPosition_{DateTime.Now:yyyyMMdd_HHmm}.csv";
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using (var writer = new StreamWriter(Path.Combine(path, fileName)))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(items);
                }
            }
            catch (Exception e)
            {
                throw new CsvGeneratorGeneralException(
                    $"General error occurred when generating csv report with name {fileName}", e);
            }
        }
    }
}