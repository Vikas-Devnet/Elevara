namespace Elevara
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }


        private void Authentication_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (Properties.Settings.Default.isCredChecked) 
            {
                authUsername.Text = Properties.Settings.Default.authUsername;
                authPassword.Text = Properties.Settings.Default.authPassword;
                authRememberCredential.Checked = true;
            }
        }

        private void AuthRememberCredential_CheckedChanged(object sender, EventArgs e)
        {
            if (authRememberCredential.Checked)
            {
                Properties.Settings.Default.authUsername = authUsername.Text;
                Properties.Settings.Default.authPassword = authPassword.Text;
                Properties.Settings.Default.isCredChecked = true;
            }
            else
            {
                Properties.Settings.Default.isCredChecked = false;
            }
            Properties.Settings.Default.Save();
        }

        private void AuthLoginBtn_Click(object sender, EventArgs e)
        {
            var username = authUsername.Text;
            var password = authPassword.Text;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) { return; }
            else
            {
                Layout layout =new();
                layout.FormClosed += (s, args) => this.Close();
                layout.Show();
            }
        }

        private void AuthSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Under Development");
        }
    }
}
