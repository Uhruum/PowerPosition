﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using Services.Implementations;
using Services;
using Domain.Models;

namespace Tests
{
    [TestClass]
    public class GeneralUnitTest
    {
        private readonly string _22Hours = "22:00";
        private readonly string _23Hours = "23:00";

        [TestMethod]
        public void GivenPowerServiceWhenGetTradesInvokedThenResultIsParsed()
        {
            IPeriodMapper periodMapper = new PeriodMapper(new PeriodMapperCollectionGenerator());
            IPowerService powerService = new PowerService();
            IEnumerable<PowerTrade> powerTrades = powerService.GetTrades(DateTime.Now);
            IPowerTradeConverter powerTradeConverter = new PowerTradeConverter();
            ITradeItemConverter tradeItemConverter = new TradeItemConverter(periodMapper);

            IDictionary<int, double> trades = powerTradeConverter.ConvertToDictionary(powerTrades);
            List<TradeItem> tradeItems = tradeItemConverter.Convert(trades).ToList();

            Assert.IsNotNull(tradeItems);
            Assert.AreEqual(24, tradeItems.Count);
            Assert.IsTrue(tradeItems[23].LocalTime.Equals(_22Hours));
            Assert.IsTrue(tradeItems[0].LocalTime.Equals(_23Hours));
        }

        [TestMethod]
        public void GivenPeriodMapperCollectionGeneratorWhenGeneratePeriodMapperCollectionInvokedThenResultIsCorrect()
        {
            IPeriodMapperCollectionGenerator generator = new PeriodMapperCollectionGenerator();
            IDictionary<int, string> collection = generator.GeneratePeriodMapperCollection();
            Assert.IsNotNull(collection);
            Assert.AreEqual(24, collection.Count);
            Assert.IsTrue(collection[24].Equals(_22Hours));
            Assert.IsTrue(collection[1].Equals(_23Hours));
        }
    }
}