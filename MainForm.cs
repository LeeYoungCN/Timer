using Utils.Logging;

namespace Timer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            // 初始化日志系统
            _logger.Name = "Timer";
            LogBasicFileSink logBasicFileSink = new();
            _logger.AddSink(logBasicFileSink);
            _logger.Info("MainForm load start.");

            // 设置定时器间隔为200ms
            UpdateTimer.Interval = 200;
            UpdateTimer.Start();
            _logger.Info("Timer started with interval: " + UpdateTimer.Interval + " ms");

            // 加载配置文件
            // 初始化工作队列
            _logger.Info("MainForm load finish.");
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _logger.Info("MainForm closing.");
            UpdateTimer.Stop();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateLabel.Text = currTime.ToString("yyyy/MM/dd dddd");
            TimeLabel.Text = currTime.ToString("HH:mm:ss");
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private Logger _logger = new();
    }
}
