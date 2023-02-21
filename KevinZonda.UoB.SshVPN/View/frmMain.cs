using KevinZonda.UoB.SshVPN.Controller;

namespace KevinZonda.UoB.SshVPN.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ViewController.MainView = this;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            BaseController.StartLocally(txtUsername.Text, txtPassword.Text);
        }

        private void btnConnectGlobal_Click(object sender, EventArgs e)
        {
            BaseController.StartGlobally(txtUsername.Text, txtPassword.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            BaseController.Stop();
        }
    }
}