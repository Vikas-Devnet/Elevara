namespace Elevara
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            splashTimer.Start();
        }

        private void SplashTimerTick(object sender, EventArgs e)
        {
            if (splashProgressBar.Value < 100)
            {
                splashProgressBar.Value += 1;
                splashProgressValue.Text = splashProgressBar.Value.ToString()+"%";
            }
            else
            {
                splashTimer.Stop();
                this.Close();
            }
        }
    }
}
