using System;
using System.Configuration;
using System.ServiceProcess;
using System.Timers;
using log4net;
using Services.Abstractions;

namespace Presentation
{
    public partial class PowerPositionReportService : ServiceBase
    {
        private readonly IReportService _reportService;
        private readonly ILog _log;
        private readonly INumberValidator _numberValidator;
        private readonly Timer _timer;
        private readonly string _pathToCsvFolder;
        private readonly string _runtimeFrequencyInMin;


        public PowerPositionReportService(IReportService reportService, ILog log, INumberValidator numberValidator)
        {
            InitializeComponent();
            _pathToCsvFolder = ConfigurationManager.AppSettings["PathToCsvFolder"];
            _runtimeFrequencyInMin = ConfigurationManager.AppSettings["RuntimeFrequencyInMin"];
            _reportService = reportService;
            _log = log;
            _numberValidator = numberValidator;
            _timer = new Timer();
        }

        protected override void OnStart(string[] args)
        {
            if (!_numberValidator.IsValid(_runtimeFrequencyInMin))
            {
                _log.Error("RuntimeFrequencyInMin parameter could not be null or empty and needs to be a number!");
                return;
            }

            _timer.Elapsed += new ElapsedEventHandler(OnTimerTick);
            _timer.Interval = Convert.ToDouble(_runtimeFrequencyInMin) * 60000;
            _timer.Enabled = true;
            _reportService.GenerateReport(_pathToCsvFolder);
        }

        protected override void OnStop()
        {
        }

        private void OnTimerTick(object source, ElapsedEventArgs e)
        {
            _reportService.GenerateReport(_pathToCsvFolder);
        }
    }
}
