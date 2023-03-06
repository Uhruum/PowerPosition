using System;
using System.Collections.Generic;
using Domain.Models;
using Services.Abstractions;

namespace Services.Implementations
{
    public class ReportService : IReportService
    {
        private readonly IPowerService _powerService;
        private readonly IPowerTradeConverter _powerTradeConverter;
        private readonly ITradeItemConverter _tradeItemConverter;
        private readonly ICsvGenerator _csvGenerator;

        public ReportService(IPowerService powerService, IPowerTradeConverter powerTradeConverter, 
            ITradeItemConverter tradeItemConverter, ICsvGenerator csvGenerator)
        {
            _powerService = powerService;
            _powerTradeConverter = powerTradeConverter;
            _tradeItemConverter = tradeItemConverter;
            _csvGenerator = csvGenerator;
        }

        public void GenerateReport(string pathToCsvFolder)
        {
            IEnumerable<TradeItem> tradeItems = _tradeItemConverter.Convert(
                _powerTradeConverter.ConvertToDictionary(
                    _powerService.GetTrades(DateTime.Now))
                );
            _csvGenerator.Generate(tradeItems, pathToCsvFolder);
        }
    }
}
