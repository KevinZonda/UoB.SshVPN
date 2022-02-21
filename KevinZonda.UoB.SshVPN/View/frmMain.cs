namespace KevinZonda.UoB.SshVPN.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Controller.SshController.Start(txtUsername.Text, txtPassword.Text);
        }

        private void btnConnectGlobal_Click(object sender, EventArgs e)
        {
            Controller.SshController.Start(txtUsername.Text, txtPassword.Text);

        }
    }
}