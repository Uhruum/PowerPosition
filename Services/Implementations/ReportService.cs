using System;
using System.Collections.Generic;
using Domain.Models;
using log4net;
using Services.Abstractions;

namespace Services.Implementations
{
    public class ReportService : IReportService
    {
        private readonly IPowerService _powerService;
        private readonly IPowerTradeConverter _powerTradeConverter;
        private readonly ITradeItemConverter _tradeItemConverter;
        private readonly ICsvGenerator _csvGenerator;
        private readonly ILog _log;

        public ReportService(IPowerService powerService, IPowerTradeConverter powerTradeConverter,
            ITradeItemConverter tradeItemConverter, ICsvGenerator csvGenerator, ILog log)
        {
            _powerService = powerService;
            _powerTradeConverter = powerTradeConverter;
            _tradeItemConverter = tradeItemConverter;
            _csvGenerator = csvGenerator;
            _log = log;
        }

        public void GenerateReport(string pathToCsvFolder)
        {
            try
            {
                _log.Info("Generating report started!");
                IEnumerable<TradeItem> tradeItems = _tradeItemConverter.Convert(
                    _powerTradeConverter.ConvertToDictionary(
                        _powerService.GetTrades(DateTime.Now))
                );

                _csvGenerator.Generate(tradeItems, pathToCsvFolder);
                _log.Info("Generating report finished!");
            }
            catch (Exception e)
            {
                _log.Error(e.Message, e);
            }
        }
    }
}