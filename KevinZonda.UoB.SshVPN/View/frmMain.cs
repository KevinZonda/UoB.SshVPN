using KevinZonda.UoB.SshVPN.Controller;

namespace KevinZonda.UoB.SshVPN.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            EventController.Self.OnSshExit += (x) =>
            {
                Colour(Color.Red);
            };
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Green();
            BaseController.StartLocally(txtUsername.Text, txtPassword.Text);
        }

        private void btnConnectGlobal_Click(object sender, EventArgs e)
        {
            Green();
            BaseController.StartGlobally(txtUsername.Text, txtPassword.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            BaseController.Stop();
        }

        public void Colour(Color c)
        {
            this.Invoke(() =>
            {
                picLogo.BackColor = c;
            });
        }
        public void Green()
        {
            Colour(Color.Green);
        }

    }
}