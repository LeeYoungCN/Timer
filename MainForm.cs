namespace Timer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateLabel.Text = currTime.ToString("yyyy/MM/dd dddd");
            TimeLabel.Text = currTime.ToString("HH:mm:ss");
        }
    }
}
