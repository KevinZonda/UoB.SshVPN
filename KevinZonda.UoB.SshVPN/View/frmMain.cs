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
                Socks2Http.Stop();
                SetWorkStatus(false);
            };
        }

        private void SetWorkStatus(bool isWorking)
        {
            this.Invoke(() =>
            {
                Text = "UoB CS VPN [" + (isWorking ? "Running" : "Idle") + "]";
                picLogo.BackColor = isWorking ? Color.Green : Color.Red;
            });
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            SetWorkStatus(true);
            BaseController.StartLocally(txtUsername.Text, txtPassword.Text);
        }

        private void btnConnectGlobal_Click(object sender, EventArgs e)
        {
            SetWorkStatus(true);
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Not Valid Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Not Valid Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BaseController.StartGlobally(txtUsername.Text, txtPassword.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SetWorkStatus(false);
            BaseController.Stop();
        }

        public void Colour(Color c)
        {
            picLogo.BackColor = c;
        }

    }
}