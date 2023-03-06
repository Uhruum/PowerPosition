using System;
using System.Configuration;
using System.ServiceProcess;
using System.Timers;
using Services.Abstractions;

namespace Presentation
{
    public partial class PowerPositionReportService : ServiceBase
    {
        private readonly IReportService _reportService;
        private readonly Timer _timer;
        private readonly string _pathToCsvFolder;


        public PowerPositionReportService(IReportService reportService)
        {
            InitializeComponent();
            _pathToCsvFolder = ConfigurationManager.AppSettings["PathToCsvFolder"];
            _reportService = reportService;
            _timer = new Timer();
        }

        protected override void OnStart(string[] args)
        {
            _timer.Elapsed += new ElapsedEventHandler(OnTimerTick);
            _timer.Interval = Convert.ToDouble(ConfigurationManager.AppSettings["RuntimeFrequencyInMin"]) * 60000;
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
