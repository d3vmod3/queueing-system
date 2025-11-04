namespace queue_system
{
    public partial class QueueDisplay : Form
    {
        public QueueDisplay()
        {
            InitializeComponent();
        }

        private void Queue_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.SetRowSpan(panel1, 2);
            panel1.Height = 200;

            tableLayoutPanel1.SetRowSpan(panel2, 6);
            panel2.Height = 800;
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\3k's Photobooth\Documents\alexie\sample-loop-video.mp4";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}
