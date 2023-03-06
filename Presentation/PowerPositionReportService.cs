using System.ServiceProcess;
using System.Timers;
using Services.Abstractions;

namespace Presentation
{
    public partial class PowerPositionReportService : ServiceBase
    {
        private readonly IReportService _reportService;
        private readonly Timer _timer;

        public PowerPositionReportService(IReportService reportService)
        {
            _reportService = reportService;
            _timer = new Timer();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _timer.Elapsed += new ElapsedEventHandler(OnTimerTick);
            _timer.Interval = 3600000;
            _timer.Enabled = true;
        }

        protected override void OnStop()
        {
        }

        private void OnTimerTick(object source, ElapsedEventArgs e)
        {
            _reportService.GenerateReport();
        }
    }
}
