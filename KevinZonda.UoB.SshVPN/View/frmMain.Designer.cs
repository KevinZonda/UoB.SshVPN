namespace KevinZonda.UoB.SshVPN.View
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tblCredential = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnConnectGlobal = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblCredential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tblButtons.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCredential
            // 
            this.tblCredential.ColumnCount = 2;
            this.tblCredential.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCredential.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCredential.Controls.Add(this.txtPassword, 1, 1);
            this.tblCredential.Controls.Add(this.txtUsername, 1, 0);
            this.tblCredential.Controls.Add(this.lblUsername, 0, 0);
            this.tblCredential.Controls.Add(this.lblPassword, 0, 1);
            this.tblCredential.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCredential.Location = new System.Drawing.Point(3, 120);
            this.tblCredential.Name = "tblCredential";
            this.tblCredential.RowCount = 2;
            this.tblCredential.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCredential.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCredential.Size = new System.Drawing.Size(806, 346);
            this.tblCredential.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(115, 242);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(688, 35);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(115, 69);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(688, 35);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 71);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 244);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 30);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(812, 117);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnConnect, 1, 0);
            this.tblButtons.Controls.Add(this.btnConnectGlobal, 0, 0);
            this.tblButtons.Controls.Add(this.btnStop, 2, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(3, 472);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButtons.Size = new System.Drawing.Size(806, 112);
            this.tblButtons.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(271, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(262, 106);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect (Socks5)";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnConnectGlobal
            // 
            this.btnConnectGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnectGlobal.Location = new System.Drawing.Point(3, 3);
            this.btnConnectGlobal.Name = "btnConnectGlobal";
            this.btnConnectGlobal.Size = new System.Drawing.Size(262, 106);
            this.btnConnectGlobal.TabIndex = 1;
            this.btnConnectGlobal.Text = "Connect (Globally)";
            this.btnConnectGlobal.UseVisualStyleBackColor = true;
            this.btnConnectGlobal.Click += new System.EventHandler(this.btnConnectGlobal_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(539, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(264, 106);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblCredential, 0, 1);
            this.tblMain.Controls.Add(this.tblButtons, 0, 2);
            this.tblMain.Controls.Add(this.picLogo, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.Size = new System.Drawing.Size(812, 587);
            this.tblMain.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 587);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "University of Birmingham SSH VPN";
            this.tblCredential.ResumeLayout(false);
            this.tblCredential.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tblButtons.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblCredential;

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private PictureBox picLogo;
        private TableLayoutPanel tblButtons;
        private TableLayoutPanel tblMain;
        private Button btnConnect;
        private Button btnConnectGlobal;
        private Button btnStop;
    }
}